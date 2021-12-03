using UnityEngine;
using UnityEngine.InputSystem;

namespace MainHero.Actions
{
	public abstract class Action : ScriptableObject
	{
		public Model Performer { get; private set; }
		public bool IsInputEnabled { get; private set; }

		protected InputAction InputAction { get; private set; }

		public void Init(Model performer, InputAction inputAction)
		{
			Performer = performer;
			InputAction = inputAction;
			IsInputEnabled = false;
			OnInit();
		}

		public virtual void Disable()
		{
			DisableInput();
		}

		protected virtual void OnInit() { }

		public virtual void EnableInput()
		{
			IsInputEnabled = true;
		}

		public virtual void DisableInput()
		{
			IsInputEnabled = false;
		}
	}
}
