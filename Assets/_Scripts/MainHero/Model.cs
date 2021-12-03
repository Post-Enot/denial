using UnityEngine;
using MainHero.Actions;
using MainHero.States;

namespace MainHero
{
	public sealed class Model : MonoBehaviour
	{
		[Header("Actions:")]
		[SerializeField] private HorizontalMovement _horizontalMovement;
		[SerializeField] private UpwardMovement _upwardMovement;
		[SerializeField] private SpecialMovement _specialMovement;
		[SerializeField] private WeaponAction _weaponAction;
		[SerializeField] private BloodSpell _bloodSpell0;
		[SerializeField] private BloodSpell _bloodSpell1;
		[SerializeField] private UltimateSpell _ultimateSpell;

		[Header("Helpers:")]
		[SerializeField] private SpaceOrientation _spaceOrientation;
		[SerializeField] private Transform _bulletSpawnPoint;
		[SerializeField] private GameObject _defaultBullet;

		public Rigidbody2D Rigidbody { get; private set; }
		public View View { get; private set; }
		public SpaceOrientation SpaceOrientation => _spaceOrientation;
		public Vector3 BulletSpawnPoint => _bulletSpawnPoint.position;
		public GameObject DefaultBullet => _defaultBullet; // Нужно будет перенести в класс Inventory
		public HorizontalMovement HorizontalMovement => _horizontalMovement;
		public UpwardMovement UpwardMovement => _upwardMovement;
		public SpecialMovement SpecialMovement => _specialMovement;
		public BloodSpell BloodSpell0 => _bloodSpell0;
		public BloodSpell BloodSpell1 => _bloodSpell1;
		public UltimateSpell UltimateSpell => _ultimateSpell;

		private InputActions _inputActions;
		private State _state;

		public void ChangeState(State state)
		{
			_state = state;
			_state.Apply();
		}

		private void Awake()
		{
			Rigidbody = GetComponent<Rigidbody2D>();
			View = GetComponent<View>();
			_inputActions = new InputActions();
		}

		private void Start()
		{
			_horizontalMovement?.Init(this, _inputActions.Main.HorizontalMovement);
			_upwardMovement?.Init(this, _inputActions.Main.UpwardMovement);
			_specialMovement?.Init(this, _inputActions.Main.SpecialMovement);
			_weaponAction?.Init(this, _inputActions.Main.WeaponAction);
			_bloodSpell0?.Init(this, _inputActions.Main.BloodSpell0);
			_bloodSpell1?.Init(this, _inputActions.Main.BloodSpell1);
			_ultimateSpell?.Init(this, _inputActions.Main.UltimateSpell);
			View.VelocityParameterUpdating.Start(Rigidbody);
			ChangeState(new Default(this));
		}

		private void OnEnable()
		{
			_inputActions.Enable();
		}

		private void OnDisable()
		{
			_inputActions.Disable();
		}
	}
}
