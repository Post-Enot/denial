using System;
using System.Collections;
using UnityEngine;

public sealed class UniqueCoroutine
{
	public bool IsActive { get; private set; }

	public readonly MonoBehaviour Performer;

	private readonly Func<IEnumerator> _getRoutine;

	private Coroutine _coroutine;

	public UniqueCoroutine(MonoBehaviour performer, Func<IEnumerator> getRoutine)
	{
		Performer = performer;
		_getRoutine = getRoutine;
	}

	public void Start()
	{
		if (!IsActive)
		{
			_coroutine = Performer.StartCoroutine(Routine());
			IsActive = true;
		}
	}

	public void Stop()
	{
		Performer.StopCoroutine(_coroutine);
		IsActive = false;
	}

	private IEnumerator Routine()
	{
		yield return _getRoutine();
		IsActive = false;
	}
}

public sealed class UniqueCoroutine<T>
{
	public bool IsActive { get; private set; }

	public readonly MonoBehaviour Performer;

	private readonly Func<T, IEnumerator> _getRoutine;

	private Coroutine _coroutine;

	public UniqueCoroutine(MonoBehaviour performer, Func<T, IEnumerator> getRoutine)
	{
		Performer = performer;
		_getRoutine = getRoutine;
	}

	public void Start(T argument)
	{
		if (!IsActive)
		{
			_coroutine = Performer.StartCoroutine(Routine(argument));
			IsActive = true;
		}
	}

	public void Stop()
	{
		Performer.StopCoroutine(_coroutine);
		IsActive = false;
	}

	private IEnumerator Routine(T argument)
	{
		yield return _getRoutine(argument);
		IsActive = false;
	}
}
