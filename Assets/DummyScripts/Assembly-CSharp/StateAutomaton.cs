/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class StateAutomaton // TypeDefIndex: 11342
{
	// Fields
	private readonly CommandThreadMusicFunctionalities _gameLife; // 0x10
	private readonly IContext _context; // 0x18
	private readonly Persistents _persistents; // 0x20
	private IState _currentState; // 0x28
	private ICombatFiercenessTeller _fiercenessTeller; // 0x30
	private WeakTransitionCallbacks _transitionCallbacks; // 0x38

	// Properties
	public uint currentStateValue { /* [XID] */ /* 0x0000000189934380-0x00000001899343A0 */ get => default; } // 0x0000000183009D20-0x0000000183009DE0 
	public bool isInCombatState { /* [XID] */ /* 0x000000018993C0D0-0x000000018993C0F0 */ get => default; } // 0x0000000183009BC0-0x0000000183009C80 
	public System.Type currentStateType { /* [XID] */ /* 0x0000000189943470-0x0000000189943490 */ get => default; } // 0x0000000183009DE0-0x0000000183009E90 

	// Events
	public event TransitionCallback onTransition;

	// Nested types
	private class Context : IContext // TypeDefIndex: 11343
	{
		// Fields
		private StateAutomaton _automaton; // 0x10

		// Constructors
		public Context() {} // Dummy constructor
		public Context(StateAutomaton automaton) {} // 0x0000000182FF62E0-0x0000000182FF6350

		// Methods
		// [XID] // 0x00000001898FCFA0-0x00000001898FCFC0
		public ConfigAudioMusic GetConfig() => default; // 0x0000000182FF5EE0-0x0000000182FF5FB0
		// [XID] // 0x000000018999DA40-0x000000018999DA60
		public Persistents GetPersistents() => default; // 0x0000000182FF6230-0x0000000182FF62E0
		// [XID] // 0x00000001899A5380-0x00000001899A53A0
		public float GetCombatFierceness() => default; // 0x0000000182FF5FB0-0x0000000182FF60A0
		// [XID] // 0x00000001899ACDF0-0x00000001899ACE10
		public void SetFiercenessRtpcValue(float value) {} // 0x0000000182FF6160-0x0000000182FF6230
		// [XID] // 0x0000000189A56920-0x0000000189A56940
		public void PostTrigger(uint triggerId) {} // 0x0000000182FF60A0-0x0000000182FF6160
	}

	private class WeakTransitionCallbacks : WeakAction<StateTag, StateTag, Persistents, TransitionCallback> // TypeDefIndex: 11344
	{
		// Constructors
		public WeakTransitionCallbacks() {} // 0x0000000182FF6CB0-0x0000000182FF6D20

		// Methods
		// [XID] // 0x0000000189A65D00-0x0000000189A65D20
		protected override void Invoke(StateTag param1, StateTag param2, Persistents param3, TransitionCallback handler) {} // 0x0000000182FF6BB0-0x0000000182FF6CB0
	}

	// Constructors
	public StateAutomaton() {} // Dummy constructor
	public StateAutomaton(CommandThreadMusicFunctionalities gameLife) {} // 0x0000000183009E90-0x0000000183009F90

	// Methods
	// [XID] // 0x000000018994ABC0-0x000000018994ABE0
	public void Init() {} // 0x0000000183009750-0x0000000183009810
	// [XID] // 0x0000000189844BB0-0x0000000189844BD0
	public void Tick() {} // 0x00000001830098D0-0x0000000183009970
	// [XID] // 0x00000001899599F0-0x0000000189959A10
	public void Input(Input input) {} // 0x00000001830095D0-0x0000000183009750
	// [XID] // 0x0000000189961330-0x0000000189961350
	public void UpdateEnemyStatusParameters(EnemyStatusParameters parameters) {} // 0x00000001830090E0-0x0000000183009430
	// [XID] // 0x000000018982E530-0x000000018982E550
	public void UpdateMapArea(uint areaStateValue, uint subStateGroup, uint defaultSubState) {} // 0x0000000183009970-0x0000000183009B00
	// [XID] // 0x000000018996FFC0-0x000000018996FFE0
	public void UpdateBoundary(string name) {} // 0x0000000183008FA0-0x00000001830090E0
	// [XID] // 0x0000000189977E20-0x0000000189977E40
	public void RegisterCombatFiercenessTeller(ICombatFiercenessTeller teller) {} // 0x0000000183009430-0x00000001830094E0
	// [XID] // 0x000000018997EFD0-0x000000018997EFF0
	public void RemoveCombatFiercenessTeller() {} // 0x0000000183009C80-0x0000000183009D20
	// [XID] // 0x0000000189986990-0x00000001899869B0
	private void OnTransition(StateTag from, StateTag to) {} // 0x00000001830094E0-0x00000001830095D0
	// [XID] // 0x0000000189A4C2A0-0x0000000189A4C2C0
	private void PostTrigger(uint triggerId) {} // 0x0000000183009810-0x00000001830098D0
}

