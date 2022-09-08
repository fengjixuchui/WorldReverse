/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace InControl
{
	public abstract class PlayerActionSet // TypeDefIndex: 7610
	{
		// Fields
		public BindingSourceType LastInputType; // 0x38
		public ulong LastInputTypeChangedTick; // 0x48
		public InputDeviceClass LastDeviceClass; // 0x50
		public InputDeviceStyle LastDeviceStyle; // 0x54
		private List<PlayerAction> actions; // 0x68
		private List<PlayerOneAxisAction> oneAxisActions; // 0x70
		private List<PlayerTwoAxisAction> twoAxisActions; // 0x78
		private Dictionary<string, PlayerAction> actionsByName; // 0x80
		private BindingListenOptions listenOptions; // 0x88
		internal PlayerAction listenWithAction; // 0x90
		private InputDevice activeDevice; // 0x98
		private const ushort currentDataFormatVersion = 2; // Metadata: 0x00ADEF92
	
		// Properties
		public InputDevice Device { /* [XID] */ /* 0x0000000189B0CCD0-0x0000000189B0CD10 */ get; /* [XID] */ /* 0x0000000189B16F40-0x0000000189B16F80 */ set; } // 0x0000000187F0CC20-0x0000000187F0CC80 0x0000000187F0D300-0x0000000187F0D360
		public List<InputDevice> IncludeDevices { /* [XID] */ /* 0x0000000189B21600-0x0000000189B21640 */ get; private set; } // 0x0000000187F0CD40-0x0000000187F0CDA0 0x0000000187F0D420-0x0000000187F0D480
		public List<InputDevice> ExcludeDevices { /* [XID] */ /* 0x0000000189B331E0-0x0000000189B33220 */ get; private set; } // 0x0000000187F0CCE0-0x0000000187F0CD40 0x0000000187F0D3C0-0x0000000187F0D420
		public ReadOnlyCollection<PlayerAction> Actions { /* [XID] */ /* 0x0000000189B456E0-0x0000000189B45720 */ get; private set; } // 0x0000000187F0CAE0-0x0000000187F0CB40 0x0000000187F0D2A0-0x0000000187F0D300
		public ulong UpdateTick { /* [XID] */ /* 0x0000000189B573E0-0x0000000189B57420 */ get; /* [XID] */ /* 0x0000000189B61A60-0x0000000189B61AA0 */ protected set; } // 0x0000000187F0D0C0-0x0000000187F0D120 0x0000000187F0D5C0-0x0000000187F0D620
		public bool Enabled { /* [XID] */ /* 0x0000000189B7AEA0-0x0000000189B7AEE0 */ get; set; } // 0x0000000187F0CC80-0x0000000187F0CCE0 0x0000000187F0D360-0x0000000187F0D3C0
		public bool PreventInputWhileListeningForBinding { /* [XID] */ /* 0x0000000189B8C970-0x0000000189B8C9B0 */ get; set; } // 0x0000000187F0D060-0x0000000187F0D0C0 0x0000000187F0D560-0x0000000187F0D5C0
		public object UserData { get; set; } // 0x0000000187F0D120-0x0000000187F0D180 0x0000000187F0D620-0x0000000187F0D680
		public PlayerAction this[string actionName] { /* [XID] */ /* 0x00000001897FF690-0x00000001897FF6B0 */ get => default; } // 0x0000000187F0CE50-0x0000000187F0CFB0 
		public bool IsListeningForBinding { /* [XID] */ /* 0x0000000189613C40-0x0000000189613C60 */ get; } // 0x0000000187F0CDA0-0x0000000187F0CE50 
		public BindingListenOptions ListenOptions { /* [XID] */ /* 0x0000000189BB2E50-0x0000000189BB2E70 */ get; /* [XID] */ /* 0x0000000189622AA0-0x0000000189622AC0 */ set; } // 0x0000000187F0CFB0-0x0000000187F0D060 0x0000000187F0D480-0x0000000187F0D560
		public InputDevice ActiveDevice { /* [XID] */ /* 0x00000001897A9160-0x00000001897A9180 */ get; } // 0x0000000187F0CB40-0x0000000187F0CC20 
	
		// Events
		public event Action<BindingSourceType> OnLastInputTypeChanged;
	
		// Constructors
		protected PlayerActionSet() {} // 0x0000000187F0C6B0-0x0000000187F0C9C0
	
		// Methods
		// [XID] // 0x0000000189BAD220-0x0000000189BAD240
		public void Destroy() {} // 0x0000000187F0B2D0-0x0000000187F0B3A0
		// [XID] // 0x0000000189BB4A00-0x0000000189BB4A20
		protected PlayerAction CreatePlayerAction(string name) => default; // 0x0000000187F0B0B0-0x0000000187F0B190
		// [XID] // 0x0000000189BBBF30-0x0000000189BBBF50
		internal void AddPlayerAction(PlayerAction action) {} // 0x0000000187F0AB40-0x0000000187F0ADD0
		// [XID] // 0x00000001897891C0-0x00000001897891E0
		protected PlayerOneAxisAction CreateOneAxisPlayerAction(PlayerAction negativeAction, PlayerAction positiveAction) => default; // 0x0000000187F0AFA0-0x0000000187F0B0B0
		// [XID] // 0x0000000189B54220-0x0000000189B54240
		protected PlayerTwoAxisAction CreateTwoAxisPlayerAction(PlayerAction negativeXAction, PlayerAction positiveXAction, PlayerAction negativeYAction, PlayerAction positiveYAction) => default; // 0x0000000187F0B190-0x0000000187F0B2D0
		// [XID] // 0x0000000189BDA050-0x0000000189BDA070
		public PlayerAction GetPlayerActionByName(string actionName) => default; // 0x0000000187F0B6F0-0x0000000187F0B7E0
		// [XID] // 0x00000001895E6C50-0x00000001895E6C70
		internal void Update(ulong updateTick, float deltaTime) {} // 0x0000000187F0C2D0-0x0000000187F0C6B0
		// [XID] // 0x00000001895EE6D0-0x00000001895EE6F0
		public void Reset() {} // 0x0000000187F0BE80-0x0000000187F0BF90
		// [XID] // 0x0000000189AA7A10-0x0000000189AA7A30
		private InputDevice FindActiveDevice() => default; // 0x0000000187F0B3A0-0x0000000187F0B6F0
		// [XID] // 0x0000000189AD5420-0x0000000189AD5440
		public void ClearInputState() {} // 0x0000000187F0ADD0-0x0000000187F0AFA0
		// [XID] // 0x0000000189A0F1A0-0x0000000189A0F1C0
		public bool HasBinding(BindingSource binding) => default; // 0x0000000187F0B7E0-0x0000000187F0B920
		// [XID] // 0x000000018960C500-0x000000018960C520
		public void RemoveBinding(BindingSource binding) {} // 0x0000000187F0BD50-0x0000000187F0BE80
		// [XID] // 0x0000000189631A80-0x0000000189631AA0
		public string Save() => default; // 0x0000000187F0BF90-0x0000000187F0C2D0
		// [XID] // 0x00000001896395D0-0x00000001896395F0
		public void Load(string data) {} // 0x0000000187F0B920-0x0000000187F0BD50
	}
}
