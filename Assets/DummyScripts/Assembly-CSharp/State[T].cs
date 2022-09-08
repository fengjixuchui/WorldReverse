/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public abstract class State<T> : IState // TypeDefIndex: 11341
	where T : State<T>, new()
{
	// Fields
	protected const float MAX_ENEMY_CONCERN_RANGE = 1000f; // Metadata: 0x00AE97A7
	protected static State<T> _instance;
	private readonly StateTag _tag;

	// Properties
	public static State<T> instance { get; }
	public StateTag tag { get; }
	public abstract uint audioStateValue { get; }
	protected IContext context { get; set; }

	// Constructors
	protected State() {} // Dummy constructor
	protected State(StateTag tag) {}

	// Methods
	public abstract IState Input(Input input);
	public virtual void Enter(IContext context) {}
	public virtual void Exit() {}
	protected virtual IState TryTransitToPeaceState(Input input) => default;
	protected virtual Persistents GetPersistents() => default;
	protected virtual ConfigAudioMusic GetConfig() => default;
	protected virtual float GetEnemyDetectRange() => default;
	protected virtual void PostTrigger(uint triggerId) {}
	protected virtual bool IsApproachingEnemy(Vector3 avatarToEnemy, Vector3 avatarVelocity, float threshold) => default;
	protected virtual void SetState(uint stateGroup, uint stateValue) {}
}

