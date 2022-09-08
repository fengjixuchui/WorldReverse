/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired.Utils.Classes.Data;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public class PlayerController : IPlayerController // TypeDefIndex: 3709
	{
		// Fields
		internal readonly int znFtIaPrJLvdjPGCwXFaaAeLKcr; // 0x10
		private bool PAfqntGWZaNgzmZFIOyQPuJGOCq; // 0x14
		private int iueDnAHVXVmEMnNCzSowjkddzOFv; // 0x18
		private readonly AList<Element> SERTGFptqMjtvIPNWFYznVbzAwf; // 0x20
		private readonly AList<Button> lgAkyeKCNYSjxkICDjzKgIcrtWEL; // 0x28
		private readonly AList<Axis> PbFORHCAibynPVwQMVeRWSjVVbJ; // 0x30
		private readonly ReadOnlyCollection<Element> uYCZQbMkrLLRfaHNIaSBlhhdXMi; // 0x38
		private readonly ReadOnlyCollection<Button> YUEEutEHRiXnwNizOlBTOCVAsZw; // 0x40
		private readonly ReadOnlyCollection<Axis> XPokcnKJNNUAUtIRBGdBJVNIoHAw; // 0x48
		private readonly List<Element.UvPQNSiehACJrvBONJBxEuFvEvZ> gfEREqRssWfYecQgVvMwQCxxmAh; // 0x50
		private Action<int, bool> UWUcVvwiCLhpRswJvpVbLGRpKwK; // 0x58
		private Action<int, float> bAHHEOTptXbbAuqcuBlybpNijmlo; // 0x60
		private Action<bool> TEEhmdIRbRbrcoqQUkwTruKySqN; // 0x68
	
		// Properties
		public bool enabled { get => default; set {} } // 0x0000000185BE0990-0x0000000185BE0A60 0x0000000185BE0DF0-0x0000000185BE1010
		public int playerId { get => default; set {} } // 0x0000000185BE0A60-0x0000000185BE0B30 0x0000000185BE1010-0x0000000185BE1100
		public IList<Button> buttons { get => default; } // 0x0000000185BE0720-0x0000000185BE07F0 
		public IList<Axis> axes { get => default; } // 0x0000000185BE0470-0x0000000185BE0540 
		public IList<Element> elements { get => default; } // 0x0000000185BE08C0-0x0000000185BE0990 
		public int buttonCount { get => default; } // 0x0000000185BE0650-0x0000000185BE0720 
		public int axisCount { get => default; } // 0x0000000185BE0540-0x0000000185BE0650 
		public int elementCount { get => default; } // 0x0000000185BE07F0-0x0000000185BE08C0 
		internal Player player { get => default; } // 0x0000000185BE0B30-0x0000000185BE0C10 
	
		// Events
		public event Action<int, bool> ButtonStateChangedEvent;
		public event Action<int, float> AxisValueChangedEvent;
		public event Action<bool> EnabledStateChangedEvent;
	
		// Nested types
		public class Definition // TypeDefIndex: 3710
		{
			// Fields
			public bool enabled; // 0x10
			public int playerId; // 0x14
			public ICollection<Element.Definition> elements; // 0x18
	
			// Constructors
			public Definition() {} // 0x0000000185BD3B10-0x0000000185BD3B80
		}
	
		public static class Factory // TypeDefIndex: 3711
		{
			// Methods
			public static PlayerController Create(Definition definition) => default; // 0x0000000185BD4C50-0x0000000185BD4D60
		}
	
		public abstract class Element // TypeDefIndex: 3712
		{
			// Fields
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			internal const bool defaultEnabled = true; // Metadata: 0x00AC4145
			private readonly PlayerController HQqdfhbximGRqAmWjsGgpbsZYxai; // 0x10
			private bool mgpGqOOfdWNViVdjBhZjlhAyKrC; // 0x18
			private bool PAfqntGWZaNgzmZFIOyQPuJGOCq; // 0x19
			private string EqppaAHmTQvmVSSZadzlNpPBbHM; // 0x20
			private static int[] ZVpHpEaNiQjrBbHkRqjGHXGwnKn; // 0x00
			private static int[] ZBqUxNpvfWYKbBJXwtazAZemjL; // 0x08
	
			// Properties
			protected Player player { get; } // 0x0000000185BD49D0-0x0000000185BD4AB0 
			protected bool selfAndParentEnabled { get; } // 0x0000000185BD4AB0-0x0000000185BD4B30 
			internal bool isMemberElement { get; set; } // 0x0000000185BD4970-0x0000000185BD49D0 0x0000000185BD4BF0-0x0000000185BD4C50
			public bool enabled { get; set; } // 0x0000000185BD4B30-0x0000000185BD4BF0
	
			// Nested types
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			internal enum Type // TypeDefIndex: 3713
			{
				Button = 0,
				Axis = 1,
				MouseAxis = 2,
				MouseWheelAxis = 3,
				Axis2D = 100,
				MouseAxis2D = 101,
				MouseWheel = 102
			}
	
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			internal enum TypeWithSource // TypeDefIndex: 3714
			{
				Button = 0,
				Axis = 1,
				MouseAxis = 2,
				MouseWheelAxis = 3
			}
	
			public abstract class Definition // TypeDefIndex: 3715
			{
				// Fields
				public bool enabled; // 0x10
				public string name; // 0x18
	
				// Constructors
				public Definition() {} // 0x0000000185BD36C0-0x0000000185BD3730
	
				// Methods
				internal abstract Element CreateElement(PlayerController param_00008196);
			}
	
			internal struct UvPQNSiehACJrvBONJBxEuFvEvZ // TypeDefIndex: 3716
			{
				// Fields
				public ControllerElementType jtJqVgInZRaLUQAkQAhzWYXSDiZ; // 0x00
				public int mFfLSVvRgZulYzYIyEkqCMoEiNXj; // 0x04
				public float JHgsNLxiAQVnmyfVeWejfTJocIu; // 0x08
	
				// Constructors
				public UvPQNSiehACJrvBONJBxEuFvEvZ(ControllerElementType elementType, int index, float value) {
					jtJqVgInZRaLUQAkQAhzWYXSDiZ = default;
					mFfLSVvRgZulYzYIyEkqCMoEiNXj = default;
					JHgsNLxiAQVnmyfVeWejfTJocIu = default;
				} // 0x0000000185BE87E0-0x0000000185BE87F0
			}
	
			// Constructors
			protected Element() {} // Dummy constructor
			internal Element(PlayerController parent, Definition definition) {} // 0x0000000185BD4870-0x0000000185BD4970
	
			// Methods
			internal virtual void Update() {} // 0x0000000185BD4820-0x0000000185BD4870
			protected virtual void EnabledStateChanged(bool state) {} // 0x0000000185BD47D0-0x0000000185BD4820
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			internal static Definition CreateDefinition(Type type) => default; // 0x0000000185BD4620-0x0000000185BD47D0
		}
	
		public abstract class ElementWithSource : Element // TypeDefIndex: 3717
		{
			// Fields
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			internal const int defaultActionId = -1; // Metadata: 0x00AC4172
			private int mecAvOSCkKTUzDMSKLpGqHuOJBZ; // 0x28
	
			// Properties
			public int actionId { get; } // 0x0000000185BD4490-0x0000000185BD44F0 
			public string actionName { get; set; } // 0x0000000185BD44F0-0x0000000185BD4620
	
			// Nested types
			public abstract class Definition : Element.Definition // TypeDefIndex: 3718
			{
				// Fields
				private int mecAvOSCkKTUzDMSKLpGqHuOJBZ; // 0x20
	
				// Properties
				public int actionId { get; set; } // 0x0000000185BD3B80-0x0000000185BD3BE0 0x0000000185BD4020-0x0000000185BD4080
	
				// Constructors
				public Definition() {} // 0x0000000185BD3A60-0x0000000185BD3B10
			}
	
			// Constructors
			protected ElementWithSource() {} // Dummy constructor
			internal ElementWithSource(PlayerController parent, Definition definition) {} // 0x0000000185BD43C0-0x0000000185BD4490
		}
	
		public class Axis : ElementWithSource // TypeDefIndex: 3719
		{
			// Fields
			internal const float KZXurpvCNFBAytBqPPInseosCYi = 1f; // Metadata: 0x00AC4176
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			internal const AxisCoordinateMode defaultAxisCoordinateMode = AxisCoordinateMode.Absolute; // Metadata: 0x00AC417A
			private float dnrncekBhbHUliJJmyTwATuSfTs; // 0x30
			private AxisCoordinateMode ncxsDUUsZCAjNNDATjTbnEzLcURe; // 0x34
			private bool NBOhEYGbeXsuTmrsRwBkMpKlbtk; // 0x38
	
			// Properties
			public float absoluteToRelativeSensitivity { get => default; } // 0x0000000185BC9270-0x0000000185BC92E0 
			public AxisCoordinateMode coordinateMode { get => default; } // 0x0000000185BC92E0-0x0000000185BC9340 
			public virtual float value { get => default; } // 0x0000000185BC9430-0x0000000185BC9680 
			public virtual float valueRaw { get => default; } // 0x0000000185BC9340-0x0000000185BC9430 
	
			// Nested types
			public class Definition : ElementWithSource.Definition // TypeDefIndex: 3720
			{
				// Fields
				public AxisCoordinateMode coordinateMode; // 0x28
				public float absoluteToRelativeSensitivity; // 0x2C
	
				// Constructors
				public Definition() {} // 0x0000000185BD3620-0x0000000185BD36C0
	
				// Methods
				internal override Element CreateElement(PlayerController param_000081a0) => default; // 0x0000000185BD3260-0x0000000185BD32F0
			}
	
			// Constructors
			public Axis() {} // Dummy constructor
			internal Axis(PlayerController parent, Definition definition) {} // 0x0000000185BC91A0-0x0000000185BC9270
		}
	
		public class MouseAxis : Axis // TypeDefIndex: 3721
		{
			// Properties
			public override float value { get => default; } // 0x0000000185BDD760-0x0000000185BDD910 
	
			// Nested types
			public class Definition : Axis.Definition // TypeDefIndex: 3722
			{
				// Constructors
				public Definition() {} // 0x0000000185BD39F0-0x0000000185BD3A60
	
				// Methods
				internal override Element CreateElement(PlayerController param_000081a3) => default; // 0x0000000185BD32F0-0x0000000185BD3380
			}
	
			// Constructors
			public MouseAxis() {} // Dummy constructor
			internal MouseAxis(PlayerController parent, Definition definition) {} // 0x0000000185BDD6D0-0x0000000185BDD760
		}
	
		public abstract class CompoundElement : Element // TypeDefIndex: 3723
		{
			// Fields
			private readonly List<Element> SERTGFptqMjtvIPNWFYznVbzAwf; // 0x28
	
			// Nested types
			public abstract class Definition : Element.Definition // TypeDefIndex: 3724
			{
				// Constructors
				public Definition() {} // 0x0000000185BD3730-0x0000000185BD37E0
			}
	
			// Constructors
			protected CompoundElement() {} // Dummy constructor
			internal CompoundElement(PlayerController parent, Definition definition, Definition[] elementDefinitions) {} // 0x0000000185BC9C10-0x0000000185BC9D30
	
			// Methods
			internal T KQaqMptOrhHmGWOCKcwibHIHaLV<T>(int param_000081a7)
				where T : Element => default;
			internal void LNDPlGnYyVBQBWaJvhRhAoCZFZh(List<Element> param_000081a8) {} // 0x0000000185BC9A00-0x0000000185BC9C10
			internal void uiIyqEcLjeCLLGNLkqHYomAmAGZF(Element param_000081a9) {} // 0x0000000185BC9D30-0x0000000185BC9E30
		}
	
		public class Axis2D : CompoundElement // TypeDefIndex: 3725
		{
			// Properties
			public virtual Vector2 value { get => default; } // 0x0000000185BC90B0-0x0000000185BC91A0 
	
			// Nested types
			public class Definition : CompoundElement.Definition // TypeDefIndex: 3726
			{
				// Fields
				private Axis.Definition TczConLzViblGIuETYsaeiAvHeO; // 0x20
				private Axis.Definition ViamFGWNFlGpfoBVOxJiBHYOgEH; // 0x28
	
				// Properties
				public Axis.Definition xAxis { get => default; set {} } // 0x0000000185BD3CC0-0x0000000185BD3D20 0x0000000185BD41C0-0x0000000185BD4220
				public Axis.Definition yAxis { get => default; set {} } // 0x0000000185BD3EE0-0x0000000185BD3F40 0x0000000185BD4220-0x0000000185BD4280
	
				// Constructors
				public Definition() {} // 0x0000000185BD38F0-0x0000000185BD3950
	
				// Methods
				internal override Element CreateElement(PlayerController param_000081b1) => default; // 0x0000000185BD3530-0x0000000185BD35C0
			}
	
			// Constructors
			public Axis2D() {} // Dummy constructor
			internal Axis2D(PlayerController parent, Definition definition, Definition[] definitions) {} // 0x0000000185BC8DA0-0x0000000185BC8E30
			internal Axis2D(PlayerController parent, Definition definition) {} // 0x0000000185BC8E30-0x0000000185BC90B0
		}
	
		public sealed class MouseAxis2D : Axis2D // TypeDefIndex: 3727
		{
			// Nested types
			public class Definition : Axis2D.Definition // TypeDefIndex: 3728
			{
				// Properties
				public new MouseAxis.Definition xAxis { get => default; set {} } // 0x0000000185BD3BE0-0x0000000185BD3CC0 0x0000000185BD4080-0x0000000185BD4120
				public new MouseAxis.Definition yAxis { get => default; set {} } // 0x0000000185BD3E00-0x0000000185BD3EE0 0x0000000185BD4280-0x0000000185BD4320
	
				// Constructors
				public Definition() {} // 0x0000000185BD3950-0x0000000185BD39F0
	
				// Methods
				internal override Element CreateElement(PlayerController param_000081b6) => default; // 0x0000000185BD3380-0x0000000185BD3410
			}
	
			// Constructors
			public MouseAxis2D() {} // Dummy constructor
			internal MouseAxis2D(PlayerController parent, Definition definition) {} // 0x0000000185BDD500-0x0000000185BDD6D0
		}
	
		public sealed class Button : ElementWithSource // TypeDefIndex: 3729
		{
			// Properties
			public bool value { get => default; } // 0x0000000185BC9910-0x0000000185BC9A00 
			public bool justPressed { get => default; } // 0x0000000185BC9710-0x0000000185BC9800 
			public bool justReleased { get => default; } // 0x0000000185BC9800-0x0000000185BC9910 
	
			// Nested types
			public class Definition : ElementWithSource.Definition // TypeDefIndex: 3730
			{
				// Constructors
				public Definition() {} // 0x0000000185BD35C0-0x0000000185BD3620
	
				// Methods
				internal override Element CreateElement(PlayerController param_000081b9) => default; // 0x0000000185BD3410-0x0000000185BD34A0
			}
	
			// Constructors
			public Button() {} // Dummy constructor
			internal Button(PlayerController parent, Definition definition) {} // 0x0000000185BC9680-0x0000000185BC9710
		}
	
		public sealed class MouseWheel : Axis2D // TypeDefIndex: 3731
		{
			// Properties
			public MouseWheelAxis yAxis { get => default; } // 0x0000000185BDE370-0x0000000185BDE3E0 
	
			// Nested types
			public class Definition : Axis2D.Definition // TypeDefIndex: 3732
			{
				// Properties
				public new MouseWheelAxis.Definition xAxis { get => default; set {} } // 0x0000000185BD3D20-0x0000000185BD3E00 0x0000000185BD4120-0x0000000185BD41C0
				public new MouseWheelAxis.Definition yAxis { get => default; set {} } // 0x0000000185BD3F40-0x0000000185BD4020 0x0000000185BD4320-0x0000000185BD43C0
	
				// Constructors
				public Definition() {} // 0x0000000185BD3850-0x0000000185BD38F0
	
				// Methods
				internal override Element CreateElement(PlayerController param_000081be) => default; // 0x0000000185BD34A0-0x0000000185BD3530
			}
	
			// Constructors
			public MouseWheel() {} // Dummy constructor
			internal MouseWheel(PlayerController parent, Definition definition) {} // 0x0000000185BDE1A0-0x0000000185BDE370
		}
	
		public sealed class MouseWheelAxis : Axis // TypeDefIndex: 3733
		{
			// Fields
			private float haGvdeAzNhvXdxjkygPGsXeTzEh; // 0x40
			private float PYlaZrEbVRGEhzvzzXnFYnAPqbe; // 0x44
			private float FAoORBrTWqKCGNyMiKXRtudTOgk; // 0x48
	
			// Properties
			public float repeatRate { set {} } // 0x0000000185BDE0E0-0x0000000185BDE1A0
			public override float value { get => default; } // 0x0000000185BDE000-0x0000000185BDE080 
	
			// Nested types
			public class Definition : Axis.Definition // TypeDefIndex: 3734
			{
				// Fields
				public float repeatRate; // 0x30
	
				// Constructors
				public Definition() {} // 0x0000000185BD37E0-0x0000000185BD3850
	
				// Methods
				internal override Element CreateElement(PlayerController param_000081c3) => default; // 0x0000000185BD31D0-0x0000000185BD3260
			}
	
			// Constructors
			public MouseWheelAxis() {} // Dummy constructor
			internal MouseWheelAxis(PlayerController parent, Definition definition) {} // 0x0000000185BDDF30-0x0000000185BDE000
	
			// Methods
			internal override void Update() {} // 0x0000000185BDDE80-0x0000000185BDDF30
			protected override void EnabledStateChanged(bool state) {} // 0x0000000185BDDD70-0x0000000185BDDE80
			private float DafgjXGnwnHCJGhWiGBdZDDtqJb() => default; // 0x0000000185BDD910-0x0000000185BDDD70
			private void nympziBLtYDUiPlWNRoEGqbSPfa() {} // 0x0000000185BDE080-0x0000000185BDE0E0
		}
	
		// Constructors
		public PlayerController() {} // Dummy constructor
		internal PlayerController(Definition definition) {} // 0x0000000185BDFCB0-0x0000000185BE0120
	
		// Methods
		~PlayerController() {} // 0x0000000185BDEAD0-0x0000000185BDEBD0
		public bool GetButton(int index) => default; // 0x0000000185BDF080-0x0000000185BDF1A0
		public bool GetButtonDown(int index) => default; // 0x0000000185BDEE30-0x0000000185BDEF50
		public bool GetButtonUp(int index) => default; // 0x0000000185BDEF50-0x0000000185BDF080
		public float GetAxis(int index) => default; // 0x0000000185BDED00-0x0000000185BDEE30
		public float GetAxisRaw(int index) => default; // 0x0000000185BDEBD0-0x0000000185BDED00
		public Element GetElement(int index) => default; // 0x0000000185BDF1A0-0x0000000185BDF2C0
		public T GetElement<T>(int index)
			where T : Element => default;
		private void sroidYdoPhgGWbBrpNeOeuxXjDRZ(UpdateLoopType param_00008184) {} // 0x0000000185BE1100-0x0000000185BE1190
		protected virtual bool Update(UpdateLoopType updateLoop) => default; // 0x0000000185BDF590-0x0000000185BDFCB0
		protected virtual void UpdateFinished() {} // 0x0000000185BDF2C0-0x0000000185BDF590
		protected virtual void ClearVars() {} // 0x0000000185BDEA50-0x0000000185BDEAD0
		internal void uiIyqEcLjeCLLGNLkqHYomAmAGZF(Element param_00008186) {} // 0x0000000185BE1820-0x0000000185BE19C0
		private void uiIyqEcLjeCLLGNLkqHYomAmAGZF(Element param_00008187, List<Element> param_00008188, List<Element> param_00008189, List<Button> param_0000818a, List<Axis> param_0000818b) {} // 0x0000000185BE1190-0x0000000185BE1820
		internal static int eEaeRhdMBvlgJyTeGHlQmUkRWOvh<T>(IList<T> param_0000818c, Predicate<T> param_0000818d, int param_0000818e)
			where T : Element => default;
	}
}
