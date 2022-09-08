/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.UI;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public sealed class PlayerMouse : PlayerController, IPlayerMouse, IMouseInputSource // TypeDefIndex: 3735
	{
		// Fields
		internal const bool PdDGWmDQnXTKvmwfydNERLOONzxR = true; // Metadata: 0x00AC417E
		internal const float dykSAmdJqhAzlceRfRiGAeDGQnZY = 1f; // Metadata: 0x00AC417F
		internal const bool kkLxsBINWdgNbNJfuUoYBraJjee = true; // Metadata: 0x00AC4183
		internal const MovementAreaUnit KoTTyoBlPNrvZAQgcbItGYLClfvI = MovementAreaUnit.Screen; // Metadata: 0x00AC4184
		private const int hBEzQrrNYcbiBiUeVbhcpOiiadLF = 3; // Metadata: 0x00AC4188
		private const int lIfecUDtmbTvWseEEbfxbQZAqdpH = 3; // Metadata: 0x00AC418C
		internal const string zJsoayGytsgDBtMvSQYXjntvQVe = "Movement"; // Metadata: 0x00AC4190
		internal const string IdJMLeMkTBLVORBwryhfIhWmGcQk = "Horizontal"; // Metadata: 0x00AC419C
		internal const string dwygqddOlIeGzlWSnPmJHWzMPCmS = "Vertical"; // Metadata: 0x00AC41AA
		internal const string bUbzIdgBgQqwQOamhpVwVKxCjep = "Wheel"; // Metadata: 0x00AC41B6
		internal const string InXVVDLgeWKQLGYhrgaIpWMVcuI = "Wheel Horizontal"; // Metadata: 0x00AC41BF
		internal const string LPeQBABWoxZmPlTwHDxNqebomSO = "Wheel Vertical"; // Metadata: 0x00AC41D3
		internal const string WiAvujQLGURStqkmilTHSaIiWQI = "Left Button"; // Metadata: 0x00AC41E5
		internal const string RJeGflIRPHVLZIndDMkJCebdyDxL = "Right Button"; // Metadata: 0x00AC41F4
		internal const string xGfMmJImCEYVEdWlOKvPbAmgsJY = "Middle Button"; // Metadata: 0x00AC4204
		internal static readonly ScreenRect YSjYxgDVpYPjXROHwHwxzrblxcS; // 0x00
		private readonly int ChYqYGwvDNhYTakpGivdFHvxccz; // 0x70
		private readonly int uTcrGhQTSriSmfxZwHQFUgBLdERI; // 0x74
		private readonly int WeXrkTRjHTWAbkIbgLgVvCJtoRl; // 0x78
		private readonly int UWOhvIObchKnEKBbhgpneuJIUNPq; // 0x7C
		private readonly int ciflcypBiQCSCiPAWNamPTgyIgw; // 0x80
		private readonly int dYVfaKBJSnhwKcnEdAXkLDnBFyHs; // 0x84
		private bool CHpXxlVUmLfEOfkyqwJSMgHVWfD; // 0x88
		private Vector2 VQTtsbGHvZhToSgFEPoePcOaOkr; // 0x8C
		private Vector2 MGHuEFhuPMjHIdLywCDGIGnZPpHm; // 0x94
		private Vector2 uTVCwSvYSLRKJRnKMIfIHjEvQgSc; // 0x9C
		private Vector2 iXAvxEnpxXQtkdaXtGnbLwsBxqb; // 0xA4
		private Vector2 fLKdxYGpPdOqKDTsUKvzsczEFOi; // 0xAC
		private float pWbagIeweoWFXdPIMWjGiSunaQo; // 0xB4
		private bool krfgeFkRmxCVdaeFdJkjKpnIvzWs; // 0xB8
		private Action<Vector2> WUPFYHbBtdAWHDwMFgSoDsyhJltb; // 0xC0
		private bool TrAXxkqHUEjuVgcLBLuyFsNtdQv; // 0xC8
		private ScreenRect URSyhqONoHoesXPICDrgaAoADyf; // 0xCC
		private MovementAreaUnit rWmYzzDnEamNdaytwsZXXkdVgos; // 0xDC
	
		// Properties
		public bool defaultToCenter { get => default; set {} } // 0x0000000185BE3660-0x0000000185BE3730 0x0000000185BE4610-0x0000000185BE4680
		public ScreenRect movementArea { get => default; set {} } // 0x0000000185BE3A30-0x0000000185BE3B30 0x0000000185BE46F0-0x0000000185BE4760
		public MovementAreaUnit movementAreaUnit { get => default; set {} } // 0x0000000185BE3960-0x0000000185BE3A30 0x0000000185BE4680-0x0000000185BE46F0
		public Vector2 screenPosition { get => default; set {} } // 0x0000000185BE3F30-0x0000000185BE4040 0x0000000185BE4870-0x0000000185BE48E0
		public Vector2 screenPositionPrev { get => default; } // 0x0000000185BE3E20-0x0000000185BE3F30 
		public Vector2 screenPositionDelta { get => default; } // 0x0000000185BE3D10-0x0000000185BE3E20 
		public MouseAxis xAxis { get => default; } // 0x0000000185BE4230-0x0000000185BE4370 
		public MouseAxis yAxis { get => default; } // 0x0000000185BE4370-0x0000000185BE4480 
		public MouseWheel wheel { get => default; } // 0x0000000185BE4110-0x0000000185BE4230 
		public Button leftButton { get => default; } // 0x0000000185BE3730-0x0000000185BE3830 
		public Button rightButton { get => default; } // 0x0000000185BE3C10-0x0000000185BE3D10 
		public Button middleButton { get => default; } // 0x0000000185BE3830-0x0000000185BE3960 
		public float pointerSpeed { get => default; set {} } // 0x0000000185BE3B30-0x0000000185BE3C10 0x0000000185BE4760-0x0000000185BE4870
		public bool useHardwarePointerPosition { get => default; set {} } // 0x0000000185BE4040-0x0000000185BE4110 0x0000000185BE48E0-0x0000000185BE49F0
		bool IMouseInputSource.enabled { get => default; } // 0x0000000185BE2020-0x0000000185BE2090 
		Vector2 IMouseInputSource.screenPosition { get => default; } // 0x0000000185BE2150-0x0000000185BE21C0 
		Vector2 IMouseInputSource.screenPositionDelta { get => default; } // 0x0000000185BE20E0-0x0000000185BE2150 
		Vector2 IMouseInputSource.wheelDelta { get => default; } // 0x0000000185BE21C0-0x0000000185BE2290 
		bool IMouseInputSource.locked { get => default; } // 0x0000000185BE2090-0x0000000185BE20E0 
	
		// Events
		public event Action<Vector2> ScreenPositionChangedEvent;
	
		// Nested types
		public sealed class Definition : PlayerController.Definition // TypeDefIndex: 3736
		{
			// Fields
			public bool defaultToCenter; // 0x20
			public ScreenRect movementArea; // 0x24
			public MovementAreaUnit movementAreaUnit; // 0x34
			public float pointerSpeed; // 0x38
			public bool useHardwarePointerPosition; // 0x3C
	
			// Constructors
			internal Definition() {} // 0x0000000185551030-0x00000001855510E0
		}
	
		public static class Factory // TypeDefIndex: 3737
		{
			// Methods
			public static PlayerMouse Create() => default; // 0x0000000185551B90-0x0000000185551C00
			private static PlayerMouse MdLShCgeucAqBomYFlMaHVWokJC(int param_000081d7, int param_000081d8) => default; // 0x0000000185551C00-0x00000001855521D0
			public static PlayerMouse Create(Definition definition) => default; // 0x0000000185551B10-0x0000000185551B90
		}
	
		public enum MovementAreaUnit // TypeDefIndex: 3738
		{
			Screen = 0,
			Pixel = 1
		}
	
		// Constructors
		public PlayerMouse() {} // Dummy constructor
		private PlayerMouse(Definition definition) {} // 0x0000000185BE29D0-0x0000000185BE3390
		static PlayerMouse() {} // 0x0000000185BE2930-0x0000000185BE29D0
	
		// Methods
		protected override bool Update(UpdateLoopType updateLoop) => default; // 0x0000000185BE2380-0x0000000185BE2880
		protected override void UpdateFinished() {} // 0x0000000185BE2290-0x0000000185BE2380
		protected override void ClearVars() {} // 0x0000000185BE19C0-0x0000000185BE1AF0
		private void KIZXINRaKvMGoWKXzeijQdKlcDh(Vector2 param_000081ce) {} // 0x0000000185BE1C10-0x0000000185BE1EA0
		private ScreenRect aHmMwwaCwjuAviahmZJvnRmaqtj() => default; // 0x0000000185BE3390-0x0000000185BE3530
		private void kJKRkClMNTPsPRlzyhbZGFnRuZM() {} // 0x0000000185BE4480-0x0000000185BE4560
		private static float XHMEzZNeiHlMVlNPHtdqoFAqIcS(Axis param_000081cf, float param_000081d0, float param_000081d1) => default; // 0x0000000185BE2880-0x0000000185BE2930
		bool IMouseInputSource.GetButtonDown(int param_000081d2) => default; // 0x0000000185BE1EA0-0x0000000185BE1F20
		bool IMouseInputSource.GetButtonUp(int param_000081d3) => default; // 0x0000000185BE1F20-0x0000000185BE1FA0
		bool IMouseInputSource.GetButton(int param_000081d4) => default; // 0x0000000185BE1FA0-0x0000000185BE2020
	}
}
