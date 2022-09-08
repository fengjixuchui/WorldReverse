/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.Interfaces;
using Rewired.Platforms;
using Rewired.Utils.Interfaces;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.Data.Mapping
{
	[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
	public sealed class HardwareJoystickMap : ScriptableObject, IHardwareControllerMap, IHardwareControllerMap_Internal // TypeDefIndex: 3775
	{
		// Fields
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private string controllerName; // 0x18
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private string editorControllerName; // 0x20
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private string description; // 0x28
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private string controllerGuid; // 0x30
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private string[] templateGuids; // 0x38
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private bool hideInLists; // 0x40
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private JoystickType[] joystickTypes; // 0x48
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private ControllerElementIdentifier[] elementIdentifiers; // 0x50
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private CompoundElement[] compoundElements; // 0x58
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_DirectInput directInput; // 0x60
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_RawInput rawInput; // 0x68
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_XInput xInput; // 0x70
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_OSX osx; // 0x78
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_Linux linux; // 0x80
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_WindowsUWP windowsUWP; // 0x88
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_Fallback fallback_Windows; // 0x90
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_Fallback fallback_WindowsUWP; // 0x98
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_Fallback fallback_OSX; // 0xA0
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_Fallback fallback_Linux; // 0xA8
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_Fallback fallback_Linux_PreConfigured; // 0xB0
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_Fallback fallback_Android; // 0xB8
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_Fallback fallback_iOS; // 0xC0
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_Fallback fallback_Blackberry; // 0xC8
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_Fallback fallback_WindowsPhone8; // 0xD0
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_Fallback fallback_XBox360; // 0xD8
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_Fallback fallback_XBoxOne; // 0xE0
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_Fallback fallback_PS3; // 0xE8
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_Fallback fallback_PS4; // 0xF0
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_Fallback fallback_PSM; // 0xF8
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_Fallback fallback_PSVita; // 0x100
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_Fallback fallback_Wii; // 0x108
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_Fallback fallback_WiiU; // 0x110
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_Fallback fallback_AmazonFireTV; // 0x118
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_Fallback fallback_RazerForgeTV; // 0x120
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_WebGL webGL; // 0x128
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_Ouya ouya; // 0x130
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_XboxOne xboxOne; // 0x138
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_PS4 ps4; // 0x140
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private Platform_NintendoSwitch nintendoSwitch; // 0x148
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_InternalDriver internalDriver; // 0x150
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_SDL2 sdl2_Linux; // 0x158
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_SDL2 sdl2_Windows; // 0x160
		[CustomObfuscation] // 0x0000000189748BB0-0x0000000189748BF0
		[SerializeField] // 0x0000000189748BB0-0x0000000189748BF0
		private Platform_SDL2 sdl2_OSX; // 0x168
		[CustomObfuscation] // 0x00000001898227C0-0x0000000189822800
		[SerializeField] // 0x00000001898227C0-0x0000000189822800
		private int elementIdentifierIdCounter; // 0x170
	
		// Properties
		public string ControllerName { get => default; } // 0x00000001869C0E10-0x00000001869C0E70 
		public string EditorControllerName { get => default; } // 0x00000001869C0E70-0x00000001869C0ED0 
		public Guid Guid { get => default; } // 0x00000001869C0F70-0x00000001869C1010 
		public IEnumerable<Guid> TemplateGuids { get => default; } // 0x00000001869C1110-0x00000001869C11B0 
		public IEnumerable<ControllerElementIdentifier> ElementIdentifiers { get => default; } // 0x00000001869C0ED0-0x00000001869C0F70 
		public int elementIdentifierCount { get => default; } // 0x00000001869C11B0-0x00000001869C1220 
		public bool HideInLists { get => default; } // 0x00000001869C1010-0x00000001869C1070 
		internal IEnumerable<JoystickType> JoystickTypes { get => default; } // 0x00000001869C1070-0x00000001869C1110 
		IEnumerable<IControllerElementIdentifierCommon_Internal> IHardwareControllerMap_Internal.ElementIdentifiers { get => default; } // 0x00000001869BF5D0-0x00000001869BF670 
	
		// Nested types
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public abstract class Platform : IDeepCloneable // TypeDefIndex: 3776
		{
			// Fields
			public string description; // 0x10
	
			// Properties
			internal abstract InputPlatform platform { get; }
			public abstract int assignedButtonCount { get; }
			public abstract int assignedAxisCount { get; }
			internal virtual bool isAllowed { get; } // 0x00000001869CFF10-0x00000001869CFFC0 
			internal abstract bool hasData { get; }
			internal abstract bool disabled { get; }
			internal abstract IList<Platform> variants_base { get; }
			internal IEnumerable<Platform> Variants { get; } // 0x00000001869CFE00-0x00000001869CFEA0 
			internal bool hasVariants { get; } // 0x00000001869CFEA0-0x00000001869CFF10 
			[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
			internal int variantCount { get; } // 0x00000001869D0680-0x00000001869D0730 
			internal bool selfOrVariantHasData { get; } // 0x00000001869CFFC0-0x00000001869D0230 
			internal bool selfOrVariantIsValid { get; } // 0x00000001869D03E0-0x00000001869D0680 
			internal bool selfOrVariantIsAllowed { get; } // 0x00000001869D0230-0x00000001869D03E0 
	
			// Constructors
			protected Platform() {} // 0x00000001869CFDA0-0x00000001869CFE00
	
			// Methods
			internal abstract bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap);
			internal abstract void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes);
			internal abstract bool IsElementIdentifierMapped(int elementIdentifierId);
			internal Platform GetFirstValidPlatformMap(out int variantIndex) {
				variantIndex = default;
				return default;
			} // 0x00000001869C8D00-0x00000001869C8F80
			internal abstract AxisCalibrationData[] GetAxisCalibrationData();
			internal abstract void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos);
			internal abstract void GetButtonData(out HardwareButtonInfo[] buttonInfos);
			internal abstract ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier);
			internal abstract bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange);
			internal Platform GetPlatformMap(int variantIndex) => default; // 0x00000001869C8F80-0x00000001869C90A0
			internal HardwareJoystickMap_InputManager ToHardwareJoystickMap_InputManager(HardwareJoystickMap hardwareJoystickMap, InputSource inputSource, InputPlatform actualInputPlatform, int variantIndex) => default; // 0x00000001869CE5A0-0x00000001869CFDA0
			public abstract object DeepClone();
			internal abstract void CopyVars(Platform destination);
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public abstract class Elements_Base : IDeepCloneable // TypeDefIndex: 3778
		{
			// Properties
			public abstract int buttonCount { get; }
			public abstract int axisCount { get; }
	
			// Constructors
			protected Elements_Base() {} // 0x00000001869B9260-0x00000001869B92C0
	
			// Methods
			internal virtual void CopyVars(Elements_Base destination) {} // 0x00000001869B9210-0x00000001869B9260
			internal abstract ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier);
			internal abstract bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange);
			public abstract object DeepClone();
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public abstract class MatchingCriteria_Base : IDeepCloneable // TypeDefIndex: 3779
		{
			// Fields
			public int axisCount; // 0x10
			public int buttonCount; // 0x14
			public bool disabled; // 0x18
			public string tag; // 0x20
	
			// Properties
			internal abstract bool hasData { get; }
			internal virtual bool isAllowed { get; } // 0x00000001869C1DF0-0x00000001869C1E50 
			internal abstract int alternateElementCount { get; }
	
			// Nested types
			[Serializable]
			public class ElementCount_Base : IDeepCloneable // TypeDefIndex: 3780
			{
				// Fields
				public int axisCount; // 0x10
				public int buttonCount; // 0x14
	
				// Constructors
				public ElementCount_Base() {} // 0x00000001869B8BD0-0x00000001869B8C30
	
				// Methods
				public virtual object DeepClone() => default; // 0x00000001869B8A70-0x00000001869B8B40
				internal virtual void CopyVars(ElementCount_Base param_00008296) {} // 0x00000001869B8A00-0x00000001869B8A70
				internal virtual bool Matches(BridgedControllerHWInfo param_00008297) => default; // 0x00000001869B8B40-0x00000001869B8BD0
			}
	
			// Constructors
			protected MatchingCriteria_Base() {} // 0x00000001869C1D90-0x00000001869C1DF0
	
			// Methods
			internal virtual bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch) => default; // 0x00000001869C1AA0-0x00000001869C1BD0
			internal abstract ElementCount_Base GetAlternateElementCount(int index);
			internal virtual bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) {
				alternateMatched = default;
				return default;
			} // 0x00000001869C1900-0x00000001869C1AA0
			internal virtual void CopyVars(MatchingCriteria_Base destination) {} // 0x00000001869C1870-0x00000001869C1900
			internal static bool StringMatches(string searchIn, string searchFor, bool useRegex) => default; // 0x00000001869C1BD0-0x00000001869C1D90
			public abstract object DeepClone();
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class CompoundElement : IDeepCloneable // TypeDefIndex: 3781
		{
			// Fields
			public CompoundControllerElementType type; // 0x10
			public int elementIdentifier; // 0x14
			public int[] componentElementIdentifiers; // 0x18
	
			// Properties
			public int elementCount { get => default; } // 0x00000001869B54B0-0x00000001869B5520 
	
			// Constructors
			public CompoundElement() {} // 0x00000001869B5330-0x00000001869B53F0
			public CompoundElement(CompoundElement original) {} // 0x00000001869B53F0-0x00000001869B54B0
	
			// Methods
			public int GetComponentElementIdentifierId(int index) => default; // 0x00000001869B4D50-0x00000001869B4E50
			public virtual object DeepClone() => default; // 0x00000001869B4CD0-0x00000001869B4D50
			protected virtual void ImportVars(CompoundElement source) {} // 0x00000001869B4E50-0x00000001869B4EF0
			internal static void SortHatElementsClockwise(CompoundElement element) {} // 0x00000001869B4EF0-0x00000001869B5330
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class VidPid // TypeDefIndex: 3782
		{
			// Fields
			public int vendorId; // 0x10
			public int productId; // 0x14
	
			// Constructors
			public VidPid() {} // 0x000000018510FC40-0x000000018510FCA0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class AxisCalibrationInfoEntry : IDeepCloneable // TypeDefIndex: 3783
		{
			// Fields
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			internal AlternateAxisCalibrationType key; // 0x10
			[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
			internal AxisCalibrationInfo calibration; // 0x18
	
			// Constructors
			public AxisCalibrationInfoEntry() {} // Dummy constructor
			public AxisCalibrationInfoEntry(AxisCalibrationInfoEntry original) {} // 0x00000001869B2400-0x00000001869B2490
	
			// Methods
			public virtual object DeepClone() => default; // 0x00000001869B1F90-0x00000001869B2010
			protected virtual void ImportVars(AxisCalibrationInfoEntry source) {} // 0x00000001869B2010-0x00000001869B20C0
			public static Dictionary<int, AxisCalibrationInfo> ToDictionary(AxisCalibrationInfoEntry[] calibrations, bool deepClone) => default; // 0x00000001869B20C0-0x00000001869B2400
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public abstract class Platform_RawOrDirectInput : Platform // TypeDefIndex: 3784
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
	
			// Properties
			internal override bool hasData { get; } // 0x00000001871A7B30-0x00000001871A7BE0 
			internal override bool disabled { get; } // 0x00000001871A7AC0-0x00000001871A7B30 
			internal override bool isAllowed { get; } // 0x00000001871A7BE0-0x00000001871A7C70 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 3785
			{
				// Fields
				public int hatCount; // 0x28
				public ElementCount[] alternateElementCounts; // 0x30
				public bool productName_useRegex; // 0x38
				public string[] productName; // 0x40
				public string[] productGUID; // 0x48
				public int[] productId; // 0x50
				public DeviceType deviceType; // 0x58
	
				// Properties
				internal override bool hasData { get => default; } // 0x000000018719A820-0x000000018719A8D0 
				internal override bool isAllowed { get => default; } // 0x000000018719ADD0-0x000000018719AE40 
				internal override int alternateElementCount { get => default; } // 0x000000018719A510-0x000000018719A580 
	
				// Nested types
				[Serializable]
				public sealed class ElementCount : MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 3786
				{
					// Fields
					public int hatCount; // 0x18
	
					// Constructors
					public ElementCount() {} // 0x0000000187191800-0x0000000187191860
	
					// Methods
					public override object DeepClone() => default; // 0x0000000187191470-0x0000000187191570
					internal override void CopyVars(MatchingCriteria_Base.ElementCount_Base param_000082a9) {} // 0x00000001871913B0-0x0000000187191470
					internal override bool Matches(BridgedControllerHWInfo param_000082aa) => default; // 0x0000000187191700-0x00000001871917A0
				}
	
				// Constructors
				public MatchingCriteria() {} // 0x000000018719A200-0x000000018719A260
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) => default; // 0x0000000187198380-0x0000000187198560
				internal override ElementCount_Base GetAlternateElementCount(int index) => default; // 0x00000001871981B0-0x0000000187198260
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) {
					alternateMatched = default;
					return default;
				} // 0x0000000187198050-0x0000000187198100
				private bool ProductNameMatches(BridgedControllerHWInfo controller) => default; // 0x0000000187199F10-0x000000018719A030
				private bool ProductNameMatches(string name) => default; // 0x0000000187199C80-0x0000000187199F10
				public override object DeepClone() => default; // 0x0000000187197D30-0x0000000187197E00
				internal override void CopyVars(MatchingCriteria_Base destination) {} // 0x00000001871973E0-0x0000000187197500
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public abstract class Elements_Platform_Base : Elements_Base // TypeDefIndex: 3787
			{
				// Constructors
				protected Elements_Platform_Base() {} // 0x0000000187194B60-0x0000000187194BC0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public class CustomCalculationSourceData : IDeepCloneable // TypeDefIndex: 3788
			{
				// Fields
				public int sourceType; // 0x10
				public int sourceAxis; // 0x14
				public int sourceButton; // 0x18
				public int sourceOtherAxis; // 0x1C
				public AxisRange sourceAxisRange; // 0x20
				public float axisDeadZone; // 0x24
				public bool invert; // 0x28
				public AxisCalibrationType axisCalibrationType; // 0x2C
				public float axisZero; // 0x30
				public float axisMin; // 0x34
				public float axisMax; // 0x38
	
				// Constructors
				public CustomCalculationSourceData() {} // 0x00000001871907A0-0x0000000187190800
	
				// Methods
				public object DeepClone() => default; // 0x0000000187190680-0x00000001871907A0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public abstract class Element : IDeepCloneable // TypeDefIndex: 3789
			{
				// Fields
				public CustomCalculation customCalculation; // 0x10
				public CustomCalculationSourceData[] customCalculationSourceData; // 0x18
	
				// Constructors
				protected Element() {} // 0x0000000187191A00-0x0000000187191A60
	
				// Methods
				public abstract object DeepClone();
				protected void ImportVars(Element source) {} // 0x0000000187191860-0x00000001871918F0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public abstract class Button_Base : Element // TypeDefIndex: 3790
			{
				// Fields
				public int elementIdentifier; // 0x20
				public HardwareElementSourceTypeWithHat sourceType; // 0x24
				public int sourceButton; // 0x28
				public int sourceAxis; // 0x2C
				public Pole sourceAxisPole; // 0x30
				public float axisDeadZone; // 0x34
				public int sourceHat; // 0x38
				public HatType sourceHatType; // 0x3C
				public HatDirection sourceHatDirection; // 0x40
				public bool requireMultipleButtons; // 0x44
				public int[] requiredButtons; // 0x48
				public bool ignoreIfButtonsActive; // 0x50
				public int[] ignoreIfButtonsActiveButtons; // 0x58
				public HardwareButtonInfo buttonInfo; // 0x60
	
				// Constructors
				public Button_Base() {} // 0x000000018718F590-0x000000018718F640
	
				// Methods
				protected void ImportVars(Button_Base source) {} // 0x000000018718F3C0-0x000000018718F590
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public abstract class Axis_Base : Element // TypeDefIndex: 3791
			{
				// Fields
				public int elementIdentifier; // 0x20
				public HardwareElementSourceTypeWithHat sourceType; // 0x24
				public int sourceAxis; // 0x28
				public AxisRange sourceAxisRange; // 0x2C
				public bool invert; // 0x30
				public float axisDeadZone; // 0x34
				public bool calibrateAxis; // 0x38
				public float axisZero; // 0x3C
				public float axisMin; // 0x40
				public float axisMax; // 0x44
				public HardwareAxisInfo axisInfo; // 0x48
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x50
				public int sourceButton; // 0x58
				public Pole buttonAxisContribution; // 0x5C
				public int sourceHat; // 0x60
				public AxisDirection sourceHatDirection; // 0x64
				public AxisRange sourceHatRange; // 0x68
	
				// Constructors
				public Axis_Base() {} // 0x000000018718E420-0x000000018718E4E0
	
				// Methods
				protected void ImportVars(Axis_Base source) {} // 0x000000018718E250-0x000000018718E420
			}
	
			public enum DeviceType // TypeDefIndex: 3792
			{
				Any = 0,
				Device = 17,
				Mouse = 18,
				Keyboard = 19,
				Joystick = 20,
				Gamepad = 21,
				Driving = 22,
				Flight = 23,
				FirstPerson = 24,
				ControlDevice = 25,
				ScreenPointer = 26,
				Remote = 27,
				Supplemental = 28
			}
	
			// Constructors
			protected Platform_RawOrDirectInput() {} // 0x00000001871A7A60-0x00000001871A7AC0
	
			// Methods
			internal abstract IEnumerable<Axis_Base> IterateAxes();
			internal abstract IEnumerable<Button_Base> IterateButtons();
			internal override void CopyVars(Platform destination) {} // 0x00000001871A7970-0x00000001871A7A60
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class Platform_DirectInput_Base : Platform_RawOrDirectInput // TypeDefIndex: 3793
		{
			// Fields
			public Elements elements; // 0x20
	
			// Properties
			internal override InputPlatform platform { get => default; } // 0x00000001869C5EA0-0x00000001869C5EF0 
			internal Axis[] Axes_orig { get => default; } // 0x00000001869C5CC0-0x00000001869C5D30 
			internal Button[] Buttons_orig { get => default; } // 0x00000001869C5D30-0x00000001869C5DA0 
			internal override IList<Platform> variants_base { get => default; } // 0x00000001869C5EF0-0x00000001869C5F40 
			public override int assignedButtonCount { get => default; } // 0x00000001869C5E20-0x00000001869C5EA0 
			public override int assignedAxisCount { get => default; } // 0x00000001869C5DA0-0x00000001869C5E20 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Elements : Platform_RawOrDirectInput.Elements_Platform_Base // TypeDefIndex: 3794
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get => default; } // 0x00000001869BB470-0x00000001869BB4E0 
				public override int axisCount { get => default; } // 0x00000001869BB2B0-0x00000001869BB320 
	
				// Constructors
				public Elements() {} // 0x00000001869BB010-0x00000001869BB070
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001869BA7E0-0x00000001869BAA10
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
					axisRange = default;
					return default;
				} // 0x00000001869BA160-0x00000001869BA510
				public override object DeepClone() => default; // 0x00000001869B96E0-0x00000001869B97B0
				internal override void CopyVars(Elements_Base destination) {} // 0x00000001869B95D0-0x00000001869B96E0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Button : Platform_RawOrDirectInput.Button_Base // TypeDefIndex: 3795
			{
				// Constructors
				public Button() {} // 0x00000001869B4420-0x00000001869B4480
	
				// Methods
				public override object DeepClone() => default; // 0x00000001869B3E30-0x00000001869B3F50
				private void ImportVars(Button source) {} // 0x00000001869B43A0-0x00000001869B4420
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Axis : Platform_RawOrDirectInput.Axis_Base // TypeDefIndex: 3796
			{
				// Constructors
				public Axis() {} // 0x00000001869B3740-0x00000001869B37A0
	
				// Methods
				public override object DeepClone() => default; // 0x00000001869B3110-0x00000001869B3250
				private void ImportVars(Axis source) {} // 0x00000001869B36C0-0x00000001869B3740
			}
	
			// Constructors
			public Platform_DirectInput_Base() {} // 0x00000001869C5C60-0x00000001869C5CC0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001869C5B70-0x00000001869C5C60
			internal override bool IsElementIdentifierMapped(int elementIdentifierId) => default; // 0x00000001869C5640-0x00000001869C5A30
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) {
				buttons = default;
				axes = default;
			} // 0x00000001869C5220-0x00000001869C5640
			internal override AxisCalibrationData[] GetAxisCalibrationData() => default; // 0x00000001869C4160-0x00000001869C4820
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) {
				axisRanges = default;
				axisInfos = default;
			} // 0x00000001869C4820-0x00000001869C4E10
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) {
				buttonInfos = default;
			} // 0x00000001869C4E10-0x00000001869C50F0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001869C5190-0x00000001869C5220
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
				axisRange = default;
				return default;
			} // 0x00000001869C50F0-0x00000001869C5190
			internal override IEnumerable<Axis_Base> IterateAxes() => default; // 0x00000001869C5A30-0x00000001869C5AD0
			internal override IEnumerable<Button_Base> IterateButtons() => default; // 0x00000001869C5AD0-0x00000001869C5B70
			public override object DeepClone() => default; // 0x00000001869C4090-0x00000001869C4160
			internal override void CopyVars(Platform destination) {} // 0x00000001869C3F70-0x00000001869C4090
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public sealed class Platform_DirectInput : Platform_DirectInput_Base // TypeDefIndex: 3799
		{
			// Fields
			public Platform_DirectInput_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Platform> variants_base { get => default; } // 0x00000001869C63C0-0x00000001869C6420 
	
			// Constructors
			public Platform_DirectInput() {} // 0x00000001869C6320-0x00000001869C63C0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001869C60C0-0x00000001869C6320
			public override object DeepClone() => default; // 0x00000001869C6020-0x00000001869C60C0
			internal override void CopyVars(Platform destination) {} // 0x00000001869C5F40-0x00000001869C6020
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class Platform_RawInput_Base : Platform_RawOrDirectInput // TypeDefIndex: 3800
		{
			// Fields
			public Elements elements; // 0x20
	
			// Properties
			internal override InputPlatform platform { get => default; } // 0x00000001871A74A0-0x00000001871A74F0 
			internal Axis[] Axes_orig { get => default; } // 0x00000001871A72C0-0x00000001871A7330 
			internal Button[] Buttons_orig { get => default; } // 0x00000001871A7330-0x00000001871A73A0 
			internal override IList<Platform> variants_base { get => default; } // 0x00000001871A74F0-0x00000001871A7540 
			public override int assignedButtonCount { get => default; } // 0x00000001871A7420-0x00000001871A74A0 
			public override int assignedAxisCount { get => default; } // 0x00000001871A73A0-0x00000001871A7420 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Elements : Platform_RawOrDirectInput.Elements_Platform_Base // TypeDefIndex: 3801
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get => default; } // 0x0000000187195300-0x0000000187195370 
				public override int axisCount { get => default; } // 0x0000000187194F10-0x0000000187194F80 
	
				// Constructors
				public Elements() {} // 0x0000000187194DA0-0x0000000187194E40
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x0000000187193F00-0x0000000187194110
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
					axisRange = default;
					return default;
				} // 0x00000001871926B0-0x0000000187192A40
				public override object DeepClone() => default; // 0x00000001871923A0-0x0000000187192440
				internal override void CopyVars(Elements_Base destination) {} // 0x0000000187191E30-0x0000000187191F30
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Button : Platform_RawOrDirectInput.Button_Base // TypeDefIndex: 3802
			{
				// Fields
				public int sourceOtherAxis; // 0x68
	
				// Constructors
				public Button() {} // 0x00000001871902E0-0x0000000187190340
	
				// Methods
				public override object DeepClone() => default; // 0x000000018718F910-0x000000018718F9F0
				private void ImportVars(Button source) {} // 0x0000000187190130-0x00000001871901C0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Axis : Platform_RawOrDirectInput.Axis_Base // TypeDefIndex: 3803
			{
				// Fields
				public int sourceOtherAxis; // 0x70
	
				// Constructors
				public Axis() {} // 0x000000018718F360-0x000000018718F3C0
	
				// Methods
				public override object DeepClone() => default; // 0x000000018718EBA0-0x000000018718ECF0
				private void ImportVars(Axis source) {} // 0x000000018718EFE0-0x000000018718F070
			}
	
			// Constructors
			public Platform_RawInput_Base() {} // 0x00000001871A7220-0x00000001871A72C0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001871A7170-0x00000001871A7220
			internal override bool IsElementIdentifierMapped(int elementIdentifierId) => default; // 0x00000001871A6D50-0x00000001871A7030
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) {
				buttons = default;
				axes = default;
			} // 0x00000001871A6930-0x00000001871A6D50
			internal override AxisCalibrationData[] GetAxisCalibrationData() => default; // 0x00000001871A55F0-0x00000001871A5C70
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) {
				axisRanges = default;
				axisInfos = default;
			} // 0x00000001871A5C70-0x00000001871A6480
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) {
				buttonInfos = default;
			} // 0x00000001871A6480-0x00000001871A6800
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001871A68A0-0x00000001871A6930
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
				axisRange = default;
				return default;
			} // 0x00000001871A6800-0x00000001871A68A0
			internal override IEnumerable<Axis_Base> IterateAxes() => default; // 0x00000001871A7030-0x00000001871A70D0
			internal override IEnumerable<Button_Base> IterateButtons() => default; // 0x00000001871A70D0-0x00000001871A7170
			public override object DeepClone() => default; // 0x00000001871A5550-0x00000001871A55F0
			internal override void CopyVars(Platform destination) {} // 0x00000001871A5450-0x00000001871A5550
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public sealed class Platform_RawInput : Platform_RawInput_Base // TypeDefIndex: 3806
		{
			// Fields
			public Platform_RawInput_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Platform> variants_base { get => default; } // 0x00000001871A7910-0x00000001871A7970 
	
			// Constructors
			public Platform_RawInput() {} // 0x00000001871A78B0-0x00000001871A7910
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001871A76E0-0x00000001871A78B0
			public override object DeepClone() => default; // 0x00000001871A7610-0x00000001871A76E0
			internal override void CopyVars(Platform destination) {} // 0x00000001871A7540-0x00000001871A7610
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class Platform_XInput_Base : Platform // TypeDefIndex: 3807
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			public override int assignedButtonCount { get => default; } // 0x0000000185100F00-0x0000000185100F80 
			public override int assignedAxisCount { get => default; } // 0x0000000185100E80-0x0000000185100F00 
			internal override InputPlatform platform { get => default; } // 0x0000000185101150-0x00000001851011A0 
			internal Axis[] Axes_orig { get => default; } // 0x0000000185100DA0-0x0000000185100E10 
			internal Button[] Buttons_orig { get => default; } // 0x0000000185100E10-0x0000000185100E80 
			internal override bool hasData { get => default; } // 0x0000000185100FF0-0x00000001851010C0 
			internal override bool disabled { get => default; } // 0x0000000185100F80-0x0000000185100FF0 
			internal override bool isAllowed { get => default; } // 0x00000001851010C0-0x0000000185101150 
			internal override IList<Platform> variants_base { get => default; } // 0x00000001851011A0-0x00000001851011F0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 3808
			{
				// Fields
				public XInputDeviceSubType[] subType; // 0x28
	
				// Properties
				internal override bool hasData { get => default; } // 0x00000001850FE360-0x00000001850FE3F0 
				internal override bool isAllowed { get => default; } // 0x00000001850FE560-0x00000001850FE5D0 
				internal override int alternateElementCount { get => default; } // 0x00000001850FE210-0x00000001850FE260 
	
				// Constructors
				public MatchingCriteria() {} // 0x00000001850FE1B0-0x00000001850FE210
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) => default; // 0x00000001850FD8B0-0x00000001850FDA70
				internal override ElementCount_Base GetAlternateElementCount(int index) => default; // 0x00000001850FD790-0x00000001850FD7E0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) {
					alternateMatched = default;
					return default;
				} // 0x00000001850FD650-0x00000001850FD6E0
				public override object DeepClone() => default; // 0x00000001850FD4B0-0x00000001850FD580
				internal override void CopyVars(MatchingCriteria_Base destination) {} // 0x00000001850FD240-0x00000001850FD320
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Elements : Elements_Base // TypeDefIndex: 3809
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get => default; } // 0x00000001850F8F60-0x00000001850F8FD0 
				public override int axisCount { get => default; } // 0x00000001850F8DA0-0x00000001850F8E10 
	
				// Constructors
				public Elements() {} // 0x00000001850F8C10-0x00000001850F8C70
	
				// Methods
				public override object DeepClone() => default; // 0x00000001850F7A10-0x00000001850F7AE0
				internal override void CopyVars(Elements_Base destination) {} // 0x00000001850F7770-0x00000001850F7840
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001850F87F0-0x00000001850F89F0
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
					axisRange = default;
					return default;
				} // 0x00000001850F8010-0x00000001850F8310
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public abstract class Element : IDeepCloneable // TypeDefIndex: 3810
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceType sourceType; // 0x14
				public XInputButton sourceButton; // 0x18
				public XInputAxis sourceAxis; // 0x1C
				public float axisDeadZone; // 0x20
	
				// Constructors
				protected Element() {} // 0x00000001850F76B0-0x00000001850F7710
	
				// Methods
				public abstract object DeepClone();
				internal virtual void CopyVars(Element destination) {} // 0x00000001850F75C0-0x00000001850F7660
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Button : Element // TypeDefIndex: 3811
			{
				// Fields
				public Pole sourceAxisPole; // 0x28
				public HardwareButtonInfo buttonInfo; // 0x30
	
				// Constructors
				public Button() {} // 0x00000001850E1B60-0x00000001850E1C10
	
				// Methods
				public override object DeepClone() => default; // 0x00000001850E1620-0x00000001850E16C0
				internal override void CopyVars(Element destination) {} // 0x00000001850E1480-0x00000001850E1590
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Axis : Element // TypeDefIndex: 3812
			{
				// Fields
				public bool invert; // 0x28
				public Pole buttonAxisContribution; // 0x2C
				public AxisRange sourceAxisRange; // 0x30
				public bool calibrateAxis; // 0x34
				public float axisZero; // 0x38
				public float axisMin; // 0x3C
				public float axisMax; // 0x40
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x48
				public HardwareAxisInfo axisInfo; // 0x50
	
				// Constructors
				public Axis() {} // 0x00000001850E13D0-0x00000001850E1480
	
				// Methods
				public override object DeepClone() => default; // 0x00000001850E0EB0-0x00000001850E0F50
				internal override void CopyVars(Element destination) {} // 0x00000001850E0D00-0x00000001850E0EB0
			}
	
			// Constructors
			public Platform_XInput_Base() {} // 0x0000000185100D40-0x0000000185100DA0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x0000000185100C90-0x0000000185100D40
			internal IEnumerable<Axis> IterateAxes() => default; // 0x0000000185100B40-0x0000000185100BE0
			internal IEnumerable<Button> IterateButtons() => default; // 0x0000000185100BE0-0x0000000185100C90
			internal override bool IsElementIdentifierMapped(int elementIdentifierId) => default; // 0x00000001851008B0-0x0000000185100B40
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) {
				buttons = default;
				axes = default;
			} // 0x00000001851004E0-0x00000001851008B0
			internal override AxisCalibrationData[] GetAxisCalibrationData() => default; // 0x00000001850FF320-0x00000001850FF9E0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) {
				axisRanges = default;
				axisInfos = default;
			} // 0x00000001850FF9E0-0x0000000185100110
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) {
				buttonInfos = default;
			} // 0x0000000185100110-0x00000001851003B0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x0000000185100450-0x00000001851004E0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
				axisRange = default;
				return default;
			} // 0x00000001851003B0-0x0000000185100450
			public override object DeepClone() => default; // 0x00000001850FF250-0x00000001850FF320
			internal override void CopyVars(Platform destination) {} // 0x00000001850FF110-0x00000001850FF250
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public sealed class Platform_XInput : Platform_XInput_Base // TypeDefIndex: 3815
		{
			// Fields
			public Platform_XInput_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Platform> variants_base { get => default; } // 0x0000000185101600-0x0000000185101660 
	
			// Constructors
			public Platform_XInput() {} // 0x0000000185101560-0x0000000185101600
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x0000000185101370-0x0000000185101560
			public override object DeepClone() => default; // 0x00000001851012D0-0x0000000185101370
			internal override void CopyVars(Platform destination) {} // 0x00000001851011F0-0x00000001851012D0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class Platform_OSX_Base : Platform // TypeDefIndex: 3816
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			public override int assignedButtonCount { get => default; } // 0x000000018719F500-0x000000018719F580 
			public override int assignedAxisCount { get => default; } // 0x000000018719F480-0x000000018719F500 
			internal override InputPlatform platform { get => default; } // 0x000000018719F730-0x000000018719F780 
			internal Button[] Buttons_orig { get => default; } // 0x000000018719F410-0x000000018719F480 
			internal Axis[] Axes_orig { get => default; } // 0x000000018719F3A0-0x000000018719F410 
			internal override bool hasData { get => default; } // 0x000000018719F5F0-0x000000018719F6A0 
			internal override bool disabled { get => default; } // 0x000000018719F580-0x000000018719F5F0 
			internal override bool isAllowed { get => default; } // 0x000000018719F6A0-0x000000018719F730 
			internal override IList<Platform> variants_base { get => default; } // 0x000000018719F780-0x000000018719F7D0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 3817
			{
				// Fields
				public int hatCount; // 0x28
				public ElementCount[] alternateElementCounts; // 0x30
				public bool productName_useRegex; // 0x38
				public string[] productName; // 0x40
				public string[] manufacturer; // 0x48
				public int[] productId; // 0x50
				public int[] vendorId; // 0x58
	
				// Properties
				internal override bool hasData { get => default; } // 0x000000018719A8D0-0x000000018719A9A0 
				internal override bool isAllowed { get => default; } // 0x000000018719AB50-0x000000018719ABC0 
				internal override int alternateElementCount { get => default; } // 0x000000018719A4A0-0x000000018719A510 
	
				// Nested types
				[Serializable]
				public sealed class ElementCount : MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 3818
				{
					// Fields
					public int hatCount; // 0x18
	
					// Constructors
					public ElementCount() {} // 0x00000001871917A0-0x0000000187191800
	
					// Methods
					public override object DeepClone() => default; // 0x0000000187191570-0x0000000187191640
					internal override void CopyVars(MatchingCriteria_Base.ElementCount_Base param_0000831b) {} // 0x0000000187191320-0x00000001871913B0
					internal override bool Matches(BridgedControllerHWInfo param_0000831c) => default; // 0x0000000187191640-0x0000000187191700
				}
	
				// Constructors
				public MatchingCriteria() {} // 0x000000018719A260-0x000000018719A2C0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) => default; // 0x0000000187198560-0x00000001871988D0
				internal override ElementCount_Base GetAlternateElementCount(int index) => default; // 0x0000000187198260-0x0000000187198330
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) {
					alternateMatched = default;
					return default;
				} // 0x0000000187197FA0-0x0000000187198050
				private bool ProductNameMatches(string name) => default; // 0x000000018719A030-0x000000018719A200
				public override object DeepClone() => default; // 0x00000001871979C0-0x0000000187197A90
				internal override void CopyVars(MatchingCriteria_Base destination) {} // 0x00000001871972A0-0x00000001871973E0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Elements : Elements_Base // TypeDefIndex: 3819
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get => default; } // 0x00000001871951B0-0x0000000187195220 
				public override int axisCount { get => default; } // 0x0000000187195060-0x00000001871950D0 
	
				// Constructors
				public Elements() {} // 0x0000000187194D40-0x0000000187194DA0
	
				// Methods
				public override object DeepClone() => default; // 0x0000000187192130-0x0000000187192200
				internal override void CopyVars(Elements_Base destination) {} // 0x0000000187191C50-0x0000000187191D60
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x0000000187194940-0x0000000187194B60
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
					axisRange = default;
					return default;
				} // 0x0000000187192A40-0x0000000187192DE0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public abstract class Element : IDeepCloneable // TypeDefIndex: 3820
			{
				// Constructors
				protected Element() {} // 0x00000001871919A0-0x0000000187191A00
	
				// Methods
				public abstract object DeepClone();
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Button : Element // TypeDefIndex: 3821
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceButton; // 0x18
				public int sourceStick; // 0x1C
				public OSXAxis sourceAxis; // 0x20
				public int sourceOtherAxis; // 0x24
				public Pole sourceAxisPole; // 0x28
				public float axisDeadZone; // 0x2C
				public int sourceHat; // 0x30
				public HatType sourceHatType; // 0x34
				public HatDirection sourceHatDirection; // 0x38
				public bool requireMultipleButtons; // 0x3C
				public int[] requiredButtons; // 0x40
				public bool ignoreIfButtonsActive; // 0x48
				public int[] ignoreIfButtonsActiveButtons; // 0x50
				public HardwareButtonInfo buttonInfo; // 0x58
	
				// Constructors
				public Button() {} // 0x0000000187190450-0x0000000187190500
	
				// Methods
				public override object DeepClone() => default; // 0x000000018718FB60-0x000000018718FD80
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Axis : Element // TypeDefIndex: 3822
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceStick; // 0x18
				public OSXAxis sourceAxis; // 0x1C
				public int sourceOtherAxis; // 0x20
				public AxisRange sourceAxisRange; // 0x24
				public bool invert; // 0x28
				public float axisDeadZone; // 0x2C
				public bool calibrateAxis; // 0x30
				public float axisZero; // 0x34
				public float axisMin; // 0x38
				public float axisMax; // 0x3C
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x40
				public HardwareAxisInfo axisInfo; // 0x48
				public int sourceButton; // 0x50
				public Pole buttonAxisContribution; // 0x54
				public int sourceHat; // 0x58
				public AxisDirection sourceHatDirection; // 0x5C
				public AxisRange sourceHatRange; // 0x60
	
				// Constructors
				public Axis() {} // 0x000000018718F180-0x000000018718F240
	
				// Methods
				public override object DeepClone() => default; // 0x000000018718E6E0-0x000000018718E890
			}
	
			// Constructors
			public Platform_OSX_Base() {} // 0x000000018719F340-0x000000018719F3A0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x000000018719F270-0x000000018719F340
			internal IEnumerable<Axis> IterateAxes() => default; // 0x000000018719F130-0x000000018719F1D0
			internal IEnumerable<Button> IterateButtons() => default; // 0x000000018719F1D0-0x000000018719F270
			internal override bool IsElementIdentifierMapped(int elementIdentifierId) => default; // 0x000000018719EDC0-0x000000018719F130
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) {
				buttons = default;
				axes = default;
			} // 0x000000018719E9D0-0x000000018719EDC0
			internal override AxisCalibrationData[] GetAxisCalibrationData() => default; // 0x000000018719D9E0-0x000000018719E060
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) {
				axisRanges = default;
				axisInfos = default;
			} // 0x000000018719E060-0x000000018719E610
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) {
				buttonInfos = default;
			} // 0x000000018719E610-0x000000018719E8A0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x000000018719E940-0x000000018719E9D0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
				axisRange = default;
				return default;
			} // 0x000000018719E8A0-0x000000018719E940
			public override object DeepClone() => default; // 0x000000018719D910-0x000000018719D9E0
			internal override void CopyVars(Platform destination) {} // 0x000000018719D800-0x000000018719D910
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public sealed class Platform_OSX : Platform_OSX_Base // TypeDefIndex: 3825
		{
			// Fields
			public Platform_OSX_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Platform> variants_base { get => default; } // 0x000000018719FBD0-0x000000018719FC30 
	
			// Constructors
			public Platform_OSX() {} // 0x000000018719FB30-0x000000018719FBD0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x000000018719F950-0x000000018719FB30
			public override object DeepClone() => default; // 0x000000018719F8B0-0x000000018719F950
			internal override void CopyVars(Platform destination) {} // 0x000000018719F7D0-0x000000018719F8B0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class Platform_Linux_Base : Platform // TypeDefIndex: 3826
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			internal override InputPlatform platform { get => default; } // 0x00000001869CE050-0x00000001869CE0A0 
			internal override bool hasData { get => default; } // 0x00000001869CDF10-0x00000001869CDFC0 
			internal override bool disabled { get => default; } // 0x00000001869CDEA0-0x00000001869CDF10 
			internal override bool isAllowed { get => default; } // 0x00000001869CDFC0-0x00000001869CE050 
			internal Axis[] Axes_orig { get => default; } // 0x00000001869CDCC0-0x00000001869CDD30 
			internal Button[] Buttons_orig { get => default; } // 0x00000001869CDD30-0x00000001869CDDA0 
			internal override IList<Platform> variants_base { get => default; } // 0x00000001869CE0A0-0x00000001869CE0F0 
			public override int assignedButtonCount { get => default; } // 0x00000001869CDE20-0x00000001869CDEA0 
			public override int assignedAxisCount { get => default; } // 0x00000001869CDDA0-0x00000001869CDE20 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 3827
			{
				// Fields
				public int hatCount; // 0x28
				public ElementCount[] alternateElementCounts; // 0x30
				public bool manufacturer_useRegex; // 0x38
				public bool productName_useRegex; // 0x39
				public bool systemName_useRegex; // 0x3A
				public string[] manufacturer; // 0x40
				public string[] productName; // 0x48
				public string[] systemName; // 0x50
				public string[] productGUID; // 0x58
	
				// Properties
				internal override bool hasData { get => default; } // 0x00000001869C39E0-0x00000001869C3AA0 
				internal override bool isAllowed { get => default; } // 0x00000001869C3C40-0x00000001869C3CF0 
				internal override int alternateElementCount { get => default; } // 0x00000001869C3830-0x00000001869C38A0 
	
				// Nested types
				[Serializable]
				public sealed class ElementCount : MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 3828
				{
					// Fields
					public int hatCount; // 0x18
	
					// Constructors
					public ElementCount() {} // 0x00000001869B8E50-0x00000001869B8EF0
	
					// Methods
					public override object DeepClone() => default; // 0x00000001869B8D10-0x00000001869B8DB0
					internal override void CopyVars(MatchingCriteria_Base.ElementCount_Base param_00008340) {} // 0x00000001869B8C30-0x00000001869B8D10
					internal override bool Matches(BridgedControllerHWInfo param_00008341) => default; // 0x00000001869B8DB0-0x00000001869B8E50
				}
	
				// Constructors
				public MatchingCriteria() {} // 0x00000001869C35A0-0x00000001869C3640
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) => default; // 0x00000001869C2940-0x00000001869C2B50
				internal override ElementCount_Base GetAlternateElementCount(int index) => default; // 0x00000001869C27F0-0x00000001869C28A0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) {
					alternateMatched = default;
					return default;
				} // 0x00000001869C26B0-0x00000001869C2760
				private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo) => default; // 0x00000001869C17B0-0x00000001869C1870
				private bool NameMatches(string name, string[] names, bool useRegex) => default; // 0x00000001869C32D0-0x00000001869C34A0
				public override object DeepClone() => default; // 0x00000001869C2430-0x00000001869C24D0
				internal override void CopyVars(MatchingCriteria_Base destination) {} // 0x00000001869C1E50-0x00000001869C1FF0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Elements : Elements_Base // TypeDefIndex: 3829
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get => default; } // 0x00000001869BB550-0x00000001869BB5C0 
				public override int axisCount { get => default; } // 0x00000001869BB400-0x00000001869BB470 
	
				// Constructors
				public Elements() {} // 0x00000001869BB170-0x00000001869BB210
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001869BAA10-0x00000001869BABE0
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
					axisRange = default;
					return default;
				} // 0x00000001869B99C0-0x00000001869B9DA0
				public override object DeepClone() => default; // 0x00000001869B97B0-0x00000001869B9850
				internal override void CopyVars(Elements_Base destination) {} // 0x00000001869B93B0-0x00000001869B94D0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public abstract class Element : IDeepCloneable // TypeDefIndex: 3830
			{
				// Constructors
				protected Element() {} // 0x00000001869B91B0-0x00000001869B9210
	
				// Methods
				public abstract object DeepClone();
				protected virtual void ImportVars(Element source) {} // 0x00000001869B90A0-0x00000001869B90F0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public class Button : Element // TypeDefIndex: 3831
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceButton; // 0x18
				public int sourceAxis; // 0x1C
				public Pole sourceAxisPole; // 0x20
				public float axisDeadZone; // 0x24
				public int sourceHat; // 0x28
				public HatType sourceHatType; // 0x2C
				public HatDirection sourceHatDirection; // 0x30
				public bool requireMultipleButtons; // 0x34
				public int[] requiredButtons; // 0x38
				public bool ignoreIfButtonsActive; // 0x40
				public int[] ignoreIfButtonsActiveButtons; // 0x48
				public HardwareButtonInfo buttonInfo; // 0x50
	
				// Constructors
				public Button() {} // 0x00000001869B45C0-0x00000001869B4680
	
				// Methods
				public override object DeepClone() => default; // 0x00000001869B4020-0x00000001869B40C0
				protected override void ImportVars(Element source) {} // 0x00000001869B4160-0x00000001869B43A0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public class Axis : Element // TypeDefIndex: 3832
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceAxis; // 0x18
				public AxisRange sourceAxisRange; // 0x1C
				public bool invert; // 0x20
				public float axisDeadZone; // 0x24
				public bool calibrateAxis; // 0x28
				public float axisZero; // 0x2C
				public float axisMin; // 0x30
				public float axisMax; // 0x34
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x38
				public HardwareAxisInfo axisInfo; // 0x40
				public int sourceButton; // 0x48
				public Pole buttonAxisContribution; // 0x4C
				public int sourceHat; // 0x50
				public AxisDirection sourceHatDirection; // 0x54
				public AxisRange sourceHatRange; // 0x58
	
				// Constructors
				public Axis() {} // 0x00000001869B38E0-0x00000001869B3990
	
				// Methods
				public override object DeepClone() => default; // 0x00000001869B3250-0x00000001869B32F0
				protected override void ImportVars(Element source) {} // 0x00000001869B3460-0x00000001869B36C0
			}
	
			// Constructors
			public Platform_Linux_Base() {} // 0x00000001869CDC20-0x00000001869CDCC0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001869CDB70-0x00000001869CDC20
			internal override bool IsElementIdentifierMapped(int elementIdentifierId) => default; // 0x00000001869CD750-0x00000001869CDA30
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) {
				buttons = default;
				axes = default;
			} // 0x00000001869CD3B0-0x00000001869CD750
			internal override AxisCalibrationData[] GetAxisCalibrationData() => default; // 0x00000001869CC020-0x00000001869CC6F0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) {
				axisRanges = default;
				axisInfos = default;
			} // 0x00000001869CC6F0-0x00000001869CCF20
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) {
				buttonInfos = default;
			} // 0x00000001869CCF20-0x00000001869CD280
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001869CD320-0x00000001869CD3B0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
				axisRange = default;
				return default;
			} // 0x00000001869CD280-0x00000001869CD320
			internal IEnumerable<Axis> IterateAxes() => default; // 0x00000001869CDA30-0x00000001869CDAD0
			internal IEnumerable<Button> IterateButtons() => default; // 0x00000001869CDAD0-0x00000001869CDB70
			public override object DeepClone() => default; // 0x00000001869CBF60-0x00000001869CC020
			internal override void CopyVars(Platform destination) {} // 0x00000001869CBE70-0x00000001869CBF60
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public sealed class Platform_Linux : Platform_Linux_Base // TypeDefIndex: 3835
		{
			// Fields
			public Platform_Linux_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Platform> variants_base { get => default; } // 0x00000001869CE540-0x00000001869CE5A0 
	
			// Constructors
			public Platform_Linux() {} // 0x00000001869CE4E0-0x00000001869CE540
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001869CE2B0-0x00000001869CE4E0
			public override object DeepClone() => default; // 0x00000001869CE1E0-0x00000001869CE2B0
			internal override void CopyVars(Platform destination) {} // 0x00000001869CE0F0-0x00000001869CE1E0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class Platform_WindowsUWP_Base : Platform // TypeDefIndex: 3836
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			internal override InputPlatform platform { get => default; } // 0x00000001871AEFF0-0x00000001871AF040 
			internal override bool hasData { get => default; } // 0x00000001871AEEB0-0x00000001871AEF60 
			internal override bool disabled { get => default; } // 0x00000001871AEE40-0x00000001871AEEB0 
			internal override bool isAllowed { get => default; } // 0x00000001871AEF60-0x00000001871AEFF0 
			internal Axis[] Axes_orig { get => default; } // 0x00000001871AEC60-0x00000001871AECD0 
			internal Button[] Buttons_orig { get => default; } // 0x00000001871AECD0-0x00000001871AED40 
			internal override IList<Platform> variants_base { get => default; } // 0x00000001871AF040-0x00000001871AF090 
			public override int assignedButtonCount { get => default; } // 0x00000001871AEDC0-0x00000001871AEE40 
			public override int assignedAxisCount { get => default; } // 0x00000001871AED40-0x00000001871AEDC0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 3837
			{
				// Fields
				public int hatCount; // 0x28
				public ElementCount[] alternateElementCounts; // 0x30
				public bool manufacturer_useRegex; // 0x38
				public bool productName_useRegex; // 0x39
				public string[] manufacturer; // 0x40
				public string[] productName; // 0x48
				public string[] productGUID; // 0x50
	
				// Properties
				internal override bool hasData { get => default; } // 0x00000001850FE2D0-0x00000001850FE360 
				internal override bool isAllowed { get => default; } // 0x00000001850FE4F0-0x00000001850FE560 
				internal override int alternateElementCount { get => default; } // 0x00000001850FE260-0x00000001850FE2D0 
	
				// Nested types
				[Serializable]
				public sealed class ElementCount : MatchingCriteria_Base.ElementCount_Base // TypeDefIndex: 3838
				{
					// Fields
					public int hatCount; // 0x18
	
					// Constructors
					public ElementCount() {} // 0x00000001850F7500-0x00000001850F7560
	
					// Methods
					public override object DeepClone() => default; // 0x00000001850F7390-0x00000001850F7460
					internal override void CopyVars(MatchingCriteria_Base.ElementCount_Base param_00008368) {} // 0x00000001850F72B0-0x00000001850F7390
					internal override bool Matches(BridgedControllerHWInfo param_00008369) => default; // 0x00000001850F7460-0x00000001850F7500
				}
	
				// Constructors
				public MatchingCriteria() {} // 0x00000001850FE150-0x00000001850FE1B0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) => default; // 0x00000001850FDCD0-0x00000001850FDF30
				internal override ElementCount_Base GetAlternateElementCount(int index) => default; // 0x00000001850FD7E0-0x00000001850FD8B0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) {
					alternateMatched = default;
					return default;
				} // 0x00000001850FD6E0-0x00000001850FD790
				private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo) => default; // 0x00000001850FD070-0x00000001850FD110
				private bool NameMatches(string name, string[] names, bool useRegex) => default; // 0x00000001850FDF30-0x00000001850FE0F0
				public override object DeepClone() => default; // 0x00000001850FD3E0-0x00000001850FD4B0
				internal override void CopyVars(MatchingCriteria_Base destination) {} // 0x00000001850FD110-0x00000001850FD240
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Elements : Elements_Base // TypeDefIndex: 3839
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get => default; } // 0x00000001850F8EF0-0x00000001850F8F60 
				public override int axisCount { get => default; } // 0x00000001850F8E10-0x00000001850F8E80 
	
				// Constructors
				public Elements() {} // 0x00000001850F8CD0-0x00000001850F8D30
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001850F89F0-0x00000001850F8C10
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
					axisRange = default;
					return default;
				} // 0x00000001850F7C80-0x00000001850F8010
				public override object DeepClone() => default; // 0x00000001850F7BB0-0x00000001850F7C80
				internal override void CopyVars(Elements_Base destination) {} // 0x00000001850F7840-0x00000001850F7920
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public abstract class Element : IDeepCloneable // TypeDefIndex: 3840
			{
				// Constructors
				protected Element() {} // 0x00000001850F7710-0x00000001850F7770
	
				// Methods
				public abstract object DeepClone();
				protected virtual void ImportVars(Element source) {} // 0x00000001850F7660-0x00000001850F76B0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public class Button : Element // TypeDefIndex: 3841
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceButton; // 0x18
				public int sourceAxis; // 0x1C
				public Pole sourceAxisPole; // 0x20
				public float axisDeadZone; // 0x24
				public int sourceHat; // 0x28
				public HatType sourceHatType; // 0x2C
				public HatDirection sourceHatDirection; // 0x30
				public bool requireMultipleButtons; // 0x34
				public int[] requiredButtons; // 0x38
				public bool ignoreIfButtonsActive; // 0x40
				public int[] ignoreIfButtonsActiveButtons; // 0x48
				public HardwareButtonInfo buttonInfo; // 0x50
	
				// Constructors
				public Button() {} // 0x00000001850E1AB0-0x00000001850E1B60
	
				// Methods
				public override object DeepClone() => default; // 0x00000001850E16C0-0x00000001850E1760
				protected override void ImportVars(Element source) {} // 0x00000001850E1830-0x00000001850E1A50
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public class Axis : Element // TypeDefIndex: 3842
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceAxis; // 0x18
				public AxisRange sourceAxisRange; // 0x1C
				public bool invert; // 0x20
				public float axisDeadZone; // 0x24
				public bool calibrateAxis; // 0x28
				public float axisZero; // 0x2C
				public float axisMin; // 0x30
				public float axisMax; // 0x34
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x38
				public HardwareAxisInfo axisInfo; // 0x40
				public int sourceButton; // 0x48
				public Pole buttonAxisContribution; // 0x4C
				public int sourceHat; // 0x50
				public AxisDirection sourceHatDirection; // 0x54
				public AxisRange sourceHatRange; // 0x58
	
				// Constructors
				public Axis() {} // 0x00000001850E1320-0x00000001850E13D0
	
				// Methods
				public override object DeepClone() => default; // 0x00000001850E1020-0x00000001850E10C0
				protected override void ImportVars(Element source) {} // 0x00000001850E10C0-0x00000001850E12C0
			}
	
			// Constructors
			public Platform_WindowsUWP_Base() {} // 0x00000001871AEC00-0x00000001871AEC60
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001871AEB50-0x00000001871AEC00
			internal override bool IsElementIdentifierMapped(int elementIdentifierId) => default; // 0x00000001871AE700-0x00000001871AEA10
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) {
				buttons = default;
				axes = default;
			} // 0x00000001871ADF40-0x00000001871AE700
			internal override AxisCalibrationData[] GetAxisCalibrationData() => default; // 0x00000001871ACBC0-0x00000001871AD240
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) {
				axisRanges = default;
				axisInfos = default;
			} // 0x00000001871AD240-0x00000001871ADA80
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) {
				buttonInfos = default;
			} // 0x00000001871ADA80-0x00000001871ADE10
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001871ADEB0-0x00000001871ADF40
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
				axisRange = default;
				return default;
			} // 0x00000001871ADE10-0x00000001871ADEB0
			internal IEnumerable<Axis> IterateAxes() => default; // 0x00000001871AEA10-0x00000001871AEAB0
			internal IEnumerable<Button> IterateButtons() => default; // 0x00000001871AEAB0-0x00000001871AEB50
			public override object DeepClone() => default; // 0x00000001871ACAF0-0x00000001871ACBC0
			internal override void CopyVars(Platform destination) {} // 0x00000001871AC9E0-0x00000001871ACAF0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public sealed class Platform_WindowsUWP : Platform_WindowsUWP_Base // TypeDefIndex: 3845
		{
			// Fields
			public Platform_WindowsUWP_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Platform> variants_base { get => default; } // 0x00000001871AF4C0-0x00000001871AF520 
	
			// Constructors
			public Platform_WindowsUWP() {} // 0x00000001871AF420-0x00000001871AF4C0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001871AF200-0x00000001871AF420
			public override object DeepClone() => default; // 0x00000001871AF160-0x00000001871AF200
			internal override void CopyVars(Platform destination) {} // 0x00000001871AF090-0x00000001871AF160
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class Platform_Fallback_Base : Platform // TypeDefIndex: 3846
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			public override int assignedButtonCount { get => default; } // 0x00000001869C8590-0x00000001869C8610 
			public override int assignedAxisCount { get => default; } // 0x00000001869C8510-0x00000001869C8590 
			internal override InputPlatform platform { get => default; } // 0x00000001869C87D0-0x00000001869C8820 
			internal Axis[] Axes_orig { get => default; } // 0x00000001869C8430-0x00000001869C84A0 
			internal Button[] Buttons_orig { get => default; } // 0x00000001869C84A0-0x00000001869C8510 
			internal override bool hasData { get => default; } // 0x00000001869C8680-0x00000001869C8740 
			internal override bool disabled { get => default; } // 0x00000001869C8610-0x00000001869C8680 
			internal override bool isAllowed { get => default; } // 0x00000001869C8740-0x00000001869C87D0 
			internal override IList<Platform> variants_base { get => default; } // 0x00000001869C8820-0x00000001869C8870 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 3847
			{
				// Fields
				public bool alwaysMatch; // 0x28
				public bool productName_useRegex; // 0x29
				public string[] productName; // 0x30
				public bool matchUnityVersion; // 0x38
				public string matchUnityVersion_min; // 0x40
				public string matchUnityVersion_max; // 0x48
				public bool matchSysVersion; // 0x50
				public string matchSysVersion_min; // 0x58
				public string matchSysVersion_max; // 0x60
	
				// Properties
				internal override bool hasData { get => default; } // 0x00000001869C3960-0x00000001869C39E0 
				internal override bool isAllowed { get => default; } // 0x00000001869C3D70-0x00000001869C3E80 
				internal override int alternateElementCount { get => default; } // 0x00000001869C37E0-0x00000001869C3830 
	
				// Constructors
				public MatchingCriteria() {} // 0x00000001869C36E0-0x00000001869C3780
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) => default; // 0x00000001869C3030-0x00000001869C32D0
				internal override ElementCount_Base GetAlternateElementCount(int index) => default; // 0x00000001869C28A0-0x00000001869C28F0
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) {
					alternateMatched = default;
					return default;
				} // 0x00000001869C2760-0x00000001869C27F0
				public override object DeepClone() => default; // 0x00000001869C24D0-0x00000001869C2570
				internal override void CopyVars(MatchingCriteria_Base destination) {} // 0x00000001869C2100-0x00000001869C2250
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Elements : Elements_Base // TypeDefIndex: 3848
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get => default; } // 0x00000001869BB5C0-0x00000001869BB630 
				public override int axisCount { get => default; } // 0x00000001869BB320-0x00000001869BB390 
	
				// Constructors
				public Elements() {} // 0x00000001869BB210-0x00000001869BB2B0
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001869BAE00-0x00000001869BB010
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
					axisRange = default;
					return default;
				} // 0x00000001869BA510-0x00000001869BA7E0
				public override object DeepClone() => default; // 0x00000001869B9850-0x00000001869B98F0
				internal override void CopyVars(Elements_Base destination) {} // 0x00000001869B94D0-0x00000001869B95D0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public class CustomCalculationSourceData : IDeepCloneable // TypeDefIndex: 3849
			{
				// Fields
				public int sourceType; // 0x10
				public int sourceElement; // 0x14
				public AxisRange sourceAxisRange; // 0x18
				public float deadzone; // 0x1C
				public bool invert; // 0x20
	
				// Constructors
				public CustomCalculationSourceData() {} // 0x00000001869B7120-0x00000001869B7180
	
				// Methods
				public object DeepClone() => default; // 0x00000001869B6EF0-0x00000001869B6FE0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public abstract class Element : IDeepCloneable // TypeDefIndex: 3850
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public UnityAxis sourceAxis; // 0x18
				public float axisDeadZone; // 0x1C
				public UnityButton sourceButton; // 0x20
				public KeyCode sourceKeyCode; // 0x24
				public CustomCalculation customCalculation; // 0x28
				public CustomCalculationSourceData[] customCalculationSourceData; // 0x30
	
				// Constructors
				protected Element() {} // 0x00000001869B90F0-0x00000001869B9150
	
				// Methods
				public abstract object DeepClone();
				protected virtual void CopyVars(Element destination) {} // 0x00000001869B8FC0-0x00000001869B90A0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Button : Element // TypeDefIndex: 3851
			{
				// Fields
				public Pole sourceAxisPole; // 0x38
				public UnityAxis unityHat_sourceAxis1; // 0x3C
				public UnityAxis unityHat_sourceAxis2; // 0x40
				public Vector2 unityHat_isActiveAxisValues1; // 0x44
				public Vector2 unityHat_isActiveAxisValues2; // 0x4C
				public Vector2 unityHat_isActiveAxisValues3; // 0x54
				public Vector2 unityHat_zeroValues; // 0x5C
				public bool unityHat_checkNeverPressed; // 0x64
				public Vector2 unityHat_neverPressedZeroValues; // 0x68
				public bool requireMultipleButtons; // 0x70
				public UnityButton[] requiredButtons; // 0x78
				public bool ignoreIfButtonsActive; // 0x80
				public UnityButton[] ignoreIfButtonsActiveButtons; // 0x88
				public HardwareButtonInfo buttonInfo; // 0x90
	
				// Constructors
				public Button() {} // 0x00000001869B4520-0x00000001869B45C0
	
				// Methods
				public override object DeepClone() => default; // 0x00000001869B40C0-0x00000001869B4160
				protected override void CopyVars(Element destination) {} // 0x00000001869B39F0-0x00000001869B3BA0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Axis : Element // TypeDefIndex: 3852
			{
				// Fields
				public bool invert; // 0x38
				public AxisRange sourceAxisRange; // 0x3C
				public Pole buttonAxisContribution; // 0x40
				public bool calibrateAxis; // 0x44
				public float axisZero; // 0x48
				public float axisMin; // 0x4C
				public float axisMax; // 0x50
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x58
				public HardwareAxisInfo axisInfo; // 0x60
	
				// Constructors
				public Axis() {} // 0x00000001869B3840-0x00000001869B38E0
	
				// Methods
				public override object DeepClone() => default; // 0x00000001869B33C0-0x00000001869B3460
				protected override void CopyVars(Element destination) {} // 0x00000001869B2F40-0x00000001869B3110
			}
	
			// Constructors
			public Platform_Fallback_Base() {} // 0x00000001869C8390-0x00000001869C8430
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001869C82B0-0x00000001869C8390
			internal IEnumerable<Axis> IterateAxes() => default; // 0x00000001869C8170-0x00000001869C8210
			internal IEnumerable<Button> IterateButtons() => default; // 0x00000001869C8210-0x00000001869C82B0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId) => default; // 0x00000001869C7E70-0x00000001869C8170
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) {
				buttons = default;
				axes = default;
			} // 0x00000001869C7A20-0x00000001869C7E70
			internal override AxisCalibrationData[] GetAxisCalibrationData() => default; // 0x00000001869C6600-0x00000001869C6D10
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) {
				axisRanges = default;
				axisInfos = default;
			} // 0x00000001869C6D10-0x00000001869C7570
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) {
				buttonInfos = default;
			} // 0x00000001869C7570-0x00000001869C78F0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001869C7990-0x00000001869C7A20
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
				axisRange = default;
				return default;
			} // 0x00000001869C78F0-0x00000001869C7990
			public override object DeepClone() => default; // 0x00000001869C6560-0x00000001869C6600
			internal override void CopyVars(Platform destination) {} // 0x00000001869C6420-0x00000001869C6560
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public sealed class Platform_Fallback : Platform_Fallback_Base // TypeDefIndex: 3855
		{
			// Fields
			public Platform_Fallback_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Platform> variants_base { get => default; } // 0x00000001869C8CA0-0x00000001869C8D00 
	
			// Constructors
			public Platform_Fallback() {} // 0x00000001869C8C40-0x00000001869C8CA0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001869C8A10-0x00000001869C8C40
			public override object DeepClone() => default; // 0x00000001869C8940-0x00000001869C8A10
			internal override void CopyVars(Platform destination) {} // 0x00000001869C8870-0x00000001869C8940
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public abstract class Platform_Custom : Platform // TypeDefIndex: 3856
		{
			// Properties
			internal abstract Axis[] Axes { get; }
			internal abstract Button[] Buttons { get; }
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public abstract class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 3857
			{
				// Fields
				public bool alwaysMatch; // 0x28
	
				// Properties
				internal override bool hasData { get; } // 0x00000001869C38F0-0x00000001869C3960 
				internal override bool isAllowed { get; } // 0x00000001869C3B90-0x00000001869C3C40 
				internal override int alternateElementCount { get; } // 0x00000001869C38A0-0x00000001869C38F0 
	
				// Constructors
				protected MatchingCriteria() {} // 0x00000001869C3640-0x00000001869C36E0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) => default; // 0x00000001869C2F40-0x00000001869C3030
				internal override ElementCount_Base GetAlternateElementCount(int index) => default; // 0x00000001869C28F0-0x00000001869C2940
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) {
					alternateMatched = default;
					return default;
				} // 0x00000001869C2570-0x00000001869C2600
				internal override void CopyVars(MatchingCriteria_Base destination) {} // 0x00000001869C1FF0-0x00000001869C2100
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public abstract class Elements : Elements_Base // TypeDefIndex: 3858
			{
				// Constructors
				protected Elements() {} // 0x00000001869BB0D0-0x00000001869BB170
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public class CustomCalculationSourceData : IDeepCloneable // TypeDefIndex: 3859
			{
				// Fields
				public int sourceType; // 0x10
				public int sourceAxis; // 0x14
				public int sourceButton; // 0x18
				public int sourceOtherAxis; // 0x1C
				public AxisRange sourceAxisRange; // 0x20
				public float axisDeadZone; // 0x24
				public bool invert; // 0x28
				public AxisCalibrationType axisCalibrationType; // 0x2C
				public float axisZero; // 0x30
				public float axisMin; // 0x34
				public float axisMax; // 0x38
	
				// Constructors
				public CustomCalculationSourceData() {} // 0x00000001869B7180-0x00000001869B71E0
	
				// Methods
				public object DeepClone() => default; // 0x00000001869B6FE0-0x00000001869B7120
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public abstract class Element : IDeepCloneable // TypeDefIndex: 3860
			{
				// Fields
				public int elementIdentifier; // 0x10
				public int sourceType; // 0x14
				public int sourceAxis; // 0x18
				public float axisDeadZone; // 0x1C
				public int sourceButton; // 0x20
				public CustomCalculation customCalculation; // 0x28
				public CustomCalculationSourceData[] customCalculationSourceData; // 0x30
	
				// Constructors
				protected Element() {} // 0x00000001869B9150-0x00000001869B91B0
	
				// Methods
				internal virtual void CopyVars(Element destination) {} // 0x00000001869B8EF0-0x00000001869B8FC0
				public abstract object DeepClone();
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public abstract class Button : Element // TypeDefIndex: 3861
			{
				// Fields
				public Pole sourceAxisPole; // 0x38
				public bool requireMultipleButtons; // 0x3C
				public int[] requiredButtons; // 0x40
				public bool ignoreIfButtonsActive; // 0x48
				public int[] ignoreIfButtonsActiveButtons; // 0x50
				public HardwareButtonInfo buttonInfo; // 0x58
	
				// Constructors
				protected Button() {} // 0x00000001869B4480-0x00000001869B4520
	
				// Methods
				internal override void CopyVars(Element destination) {} // 0x00000001869B3C70-0x00000001869B3E30
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public abstract class Axis : Element // TypeDefIndex: 3862
			{
				// Fields
				public bool invert; // 0x38
				public AxisRange sourceAxisRange; // 0x3C
				public Pole buttonAxisContribution; // 0x40
				public bool calibrateAxis; // 0x44
				public float axisZero; // 0x48
				public float axisMin; // 0x4C
				public float axisMax; // 0x50
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x58
				public HardwareAxisInfo axisInfo; // 0x60
	
				// Constructors
				protected Axis() {} // 0x00000001869B37A0-0x00000001869B3840
	
				// Methods
				internal override void CopyVars(Element destination) {} // 0x00000001869B2D30-0x00000001869B2F40
			}
	
			// Constructors
			protected Platform_Custom() {} // 0x00000001869C3ED0-0x00000001869C3F70
	
			// Methods
			internal abstract IEnumerable<Axis> IterateAxes();
			internal abstract IEnumerable<Button> IterateButtons();
			internal override void CopyVars(Platform destination) {} // 0x00000001869C3E80-0x00000001869C3ED0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class Platform_Ouya_Base : Platform_Custom // TypeDefIndex: 3863
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get => default; } // 0x00000001871A2110-0x00000001871A2190 
			public override int assignedAxisCount { get => default; } // 0x00000001871A2090-0x00000001871A2110 
			internal override InputPlatform platform { get => default; } // 0x00000001871A2340-0x00000001871A2390 
			internal override Axis[] Axes { get => default; } // 0x00000001871A1BD0-0x00000001871A1E00 
			internal override Button[] Buttons { get => default; } // 0x00000001871A1E70-0x00000001871A2020 
			internal Axis[] Axes_orig { get => default; } // 0x00000001871A1E00-0x00000001871A1E70 
			internal Button[] Buttons_orig { get => default; } // 0x00000001871A2020-0x00000001871A2090 
			internal override bool hasData { get => default; } // 0x00000001871A2200-0x00000001871A22B0 
			internal override bool disabled { get => default; } // 0x00000001871A2190-0x00000001871A2200 
			internal override bool isAllowed { get => default; } // 0x00000001871A22B0-0x00000001871A2340 
			internal override IList<Platform> variants_base { get => default; } // 0x00000001871A2390-0x00000001871A23E0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 3864
			{
				// Properties
				internal override bool hasData { get => default; } // 0x000000018719A7B0-0x000000018719A820 
				internal override bool isAllowed { get => default; } // 0x000000018719AD50-0x000000018719ADD0 
	
				// Constructors
				public MatchingCriteria() {} // 0x000000018719A2C0-0x000000018719A320
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) => default; // 0x00000001871997E0-0x00000001871998E0
				public override object DeepClone() => default; // 0x0000000187197ED0-0x0000000187197FA0
				internal override void CopyVars(MatchingCriteria_Base destination) {} // 0x0000000187197220-0x00000001871972A0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 3865
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get => default; } // 0x0000000187195220-0x0000000187195290 
				public override int axisCount { get => default; } // 0x0000000187195140-0x00000001871951B0 
	
				// Constructors
				public Elements() {} // 0x0000000187194E40-0x0000000187194EA0
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x0000000187193CD0-0x0000000187193F00
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
					axisRange = default;
					return default;
				} // 0x0000000187193680-0x0000000187193950
				public override object DeepClone() => default; // 0x0000000187192200-0x00000001871922D0
				internal override void CopyVars(Elements_Base destination) {} // 0x0000000187191F30-0x0000000187192030
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 3866
			{
				// Constructors
				public Button() {} // 0x0000000187190340-0x00000001871903A0
	
				// Methods
				public override object DeepClone() => default; // 0x000000018718F840-0x000000018718F910
				internal override void CopyVars(Platform_Custom.Element destination) {} // 0x000000018718F640-0x000000018718F6C0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 3867
			{
				// Constructors
				public Axis() {} // 0x000000018718F300-0x000000018718F360
	
				// Methods
				public override object DeepClone() => default; // 0x000000018718ECF0-0x000000018718EDC0
				internal override void CopyVars(Platform_Custom.Element destination) {} // 0x000000018718E660-0x000000018718E6E0
			}
	
			// Constructors
			public Platform_Ouya_Base() {} // 0x00000001871A1B70-0x00000001871A1BD0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001871A1A90-0x00000001871A1B70
			internal override IEnumerable<Axis> IterateAxes() => default; // 0x00000001871A1950-0x00000001871A19F0
			internal override IEnumerable<Button> IterateButtons() => default; // 0x00000001871A19F0-0x00000001871A1A90
			internal override bool IsElementIdentifierMapped(int elementIdentifierId) => default; // 0x00000001871A1600-0x00000001871A1950
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) {
				buttons = default;
				axes = default;
			} // 0x00000001871A0F70-0x00000001871A1600
			internal override AxisCalibrationData[] GetAxisCalibrationData() => default; // 0x000000018719FE60-0x00000001871A0550
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) {
				axisRanges = default;
				axisInfos = default;
			} // 0x00000001871A0550-0x00000001871A0AE0
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) {
				buttonInfos = default;
			} // 0x00000001871A0AE0-0x00000001871A0E40
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001871A0EE0-0x00000001871A0F70
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
				axisRange = default;
				return default;
			} // 0x00000001871A0E40-0x00000001871A0EE0
			public override object DeepClone() => default; // 0x000000018719FD90-0x000000018719FE60
			internal override void CopyVars(Platform destination) {} // 0x000000018719FC30-0x000000018719FD90
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public sealed class Platform_Ouya : Platform_Ouya_Base // TypeDefIndex: 3870
		{
			// Fields
			public Platform_Ouya_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Platform> variants_base { get => default; } // 0x00000001871A2800-0x00000001871A2860 
	
			// Constructors
			public Platform_Ouya() {} // 0x00000001871A2760-0x00000001871A2800
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001871A2550-0x00000001871A2760
			public override object DeepClone() => default; // 0x00000001871A24B0-0x00000001871A2550
			internal override void CopyVars(Platform destination) {} // 0x00000001871A23E0-0x00000001871A24B0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class Platform_XboxOne_Base : Platform_Custom // TypeDefIndex: 3871
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get => default; } // 0x0000000185103770-0x00000001851037F0 
			public override int assignedAxisCount { get => default; } // 0x00000001851036F0-0x0000000185103770 
			internal override InputPlatform platform { get => default; } // 0x00000001851039A0-0x00000001851039F0 
			internal override Axis[] Axes { get => default; } // 0x0000000185103210-0x00000001851033E0 
			internal override Button[] Buttons { get => default; } // 0x0000000185103450-0x0000000185103680 
			internal Axis[] Axes_orig { get => default; } // 0x00000001851033E0-0x0000000185103450 
			internal Button[] Buttons_orig { get => default; } // 0x0000000185103680-0x00000001851036F0 
			internal override bool hasData { get => default; } // 0x0000000185103860-0x0000000185103910 
			internal override bool disabled { get => default; } // 0x00000001851037F0-0x0000000185103860 
			internal override bool isAllowed { get => default; } // 0x0000000185103910-0x00000001851039A0 
			internal override IList<Platform> variants_base { get => default; } // 0x00000001851039F0-0x0000000185103A40 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 3872
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
	
				// Properties
				internal override bool hasData { get => default; } // 0x00000001850FE3F0-0x00000001850FE470 
				internal override bool isAllowed { get => default; } // 0x00000001850FE470-0x00000001850FE4F0 
	
				// Constructors
				public MatchingCriteria() {} // 0x00000001850FE0F0-0x00000001850FE150
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) => default; // 0x00000001850FDA70-0x00000001850FDCD0
				public override object DeepClone() => default; // 0x00000001850FD580-0x00000001850FD650
				internal override void CopyVars(MatchingCriteria_Base destination) {} // 0x00000001850FD320-0x00000001850FD3E0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 3873
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get => default; } // 0x00000001850F8E80-0x00000001850F8EF0 
				public override int axisCount { get => default; } // 0x00000001850F8D30-0x00000001850F8DA0 
	
				// Constructors
				public Elements() {} // 0x00000001850F8C70-0x00000001850F8CD0
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001850F8630-0x00000001850F87F0
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
					axisRange = default;
					return default;
				} // 0x00000001850F8310-0x00000001850F8630
				public override object DeepClone() => default; // 0x00000001850F7AE0-0x00000001850F7BB0
				internal override void CopyVars(Elements_Base destination) {} // 0x00000001850F7920-0x00000001850F7A10
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 3874
			{
				// Constructors
				public Button() {} // 0x00000001850E1A50-0x00000001850E1AB0
	
				// Methods
				public override object DeepClone() => default; // 0x00000001850E1760-0x00000001850E1830
				internal override void CopyVars(Platform_Custom.Element destination) {} // 0x00000001850E1590-0x00000001850E1620
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 3875
			{
				// Constructors
				public Axis() {} // 0x00000001850E12C0-0x00000001850E1320
	
				// Methods
				public override object DeepClone() => default; // 0x00000001850E0F50-0x00000001850E1020
				internal override void CopyVars(Platform_Custom.Element destination) {} // 0x00000001850E0C80-0x00000001850E0D00
			}
	
			// Constructors
			public Platform_XboxOne_Base() {} // 0x00000001851031B0-0x0000000185103210
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001851030B0-0x00000001851031B0
			internal override IEnumerable<Axis> IterateAxes() => default; // 0x0000000185102F70-0x0000000185103010
			internal override IEnumerable<Button> IterateButtons() => default; // 0x0000000185103010-0x00000001851030B0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId) => default; // 0x0000000185102C50-0x0000000185102F70
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) {
				buttons = default;
				axes = default;
			} // 0x0000000185102800-0x0000000185102C50
			internal override AxisCalibrationData[] GetAxisCalibrationData() => default; // 0x0000000185101850-0x0000000185101EF0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) {
				axisRanges = default;
				axisInfos = default;
			} // 0x0000000185101EF0-0x0000000185102450
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) {
				buttonInfos = default;
			} // 0x0000000185102450-0x00000001851026D0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x0000000185102770-0x0000000185102800
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
				axisRange = default;
				return default;
			} // 0x00000001851026D0-0x0000000185102770
			public override object DeepClone() => default; // 0x0000000185101780-0x0000000185101850
			internal override void CopyVars(Platform destination) {} // 0x0000000185101660-0x0000000185101780
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public sealed class Platform_XboxOne : Platform_XboxOne_Base // TypeDefIndex: 3878
		{
			// Fields
			public Platform_XboxOne_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Platform> variants_base { get => default; } // 0x0000000185103E10-0x0000000185103E70 
	
			// Constructors
			public Platform_XboxOne() {} // 0x0000000185103D70-0x0000000185103E10
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x0000000185103BB0-0x0000000185103D70
			public override object DeepClone() => default; // 0x0000000185103B10-0x0000000185103BB0
			internal override void CopyVars(Platform destination) {} // 0x0000000185103A40-0x0000000185103B10
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class Platform_PS4_Base : Platform_Custom // TypeDefIndex: 3879
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get => default; } // 0x00000001871A4D40-0x00000001871A4DC0 
			public override int assignedAxisCount { get => default; } // 0x00000001871A4CC0-0x00000001871A4D40 
			internal override InputPlatform platform { get => default; } // 0x00000001871A4F70-0x00000001871A4FC0 
			internal override Axis[] Axes { get => default; } // 0x00000001871A4730-0x00000001871A4990 
			internal override Button[] Buttons { get => default; } // 0x00000001871A4A00-0x00000001871A4C50 
			internal Axis[] Axes_orig { get => default; } // 0x00000001871A4990-0x00000001871A4A00 
			internal Button[] Buttons_orig { get => default; } // 0x00000001871A4C50-0x00000001871A4CC0 
			internal override bool hasData { get => default; } // 0x00000001871A4E30-0x00000001871A4EE0 
			internal override bool disabled { get => default; } // 0x00000001871A4DC0-0x00000001871A4E30 
			internal override bool isAllowed { get => default; } // 0x00000001871A4EE0-0x00000001871A4F70 
			internal override IList<Platform> variants_base { get => default; } // 0x00000001871A4FC0-0x00000001871A5010 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 3880
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
	
				// Properties
				internal override bool hasData { get => default; } // 0x000000018719A720-0x000000018719A7B0 
				internal override bool isAllowed { get => default; } // 0x000000018719ABC0-0x000000018719AC40 
	
				// Constructors
				public MatchingCriteria() {} // 0x000000018719A320-0x000000018719A380
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) => default; // 0x0000000187198B60-0x0000000187198DC0
				public override object DeepClone() => default; // 0x0000000187197A90-0x0000000187197B90
				internal override void CopyVars(MatchingCriteria_Base destination) {} // 0x00000001871978D0-0x00000001871979C0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 3881
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get => default; } // 0x0000000187195370-0x00000001871953E0 
				public override int axisCount { get => default; } // 0x0000000187194FF0-0x0000000187195060 
	
				// Constructors
				public Elements() {} // 0x0000000187194BC0-0x0000000187194C20
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x0000000187194340-0x0000000187194550
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
					axisRange = default;
					return default;
				} // 0x00000001871930B0-0x0000000187193390
				public override object DeepClone() => default; // 0x0000000187192510-0x00000001871925E0
				internal override void CopyVars(Elements_Base destination) {} // 0x0000000187192030-0x0000000187192130
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 3882
			{
				// Constructors
				public Button() {} // 0x00000001871901C0-0x0000000187190220
	
				// Methods
				public override object DeepClone() => default; // 0x000000018718FE50-0x000000018718FF20
				internal override void CopyVars(Platform_Custom.Element destination) {} // 0x000000018718F740-0x000000018718F7C0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 3883
			{
				// Constructors
				public Axis() {} // 0x000000018718F120-0x000000018718F180
	
				// Methods
				public override object DeepClone() => default; // 0x000000018718EA00-0x000000018718EAD0
				internal override void CopyVars(Platform_Custom.Element destination) {} // 0x000000018718E4E0-0x000000018718E560
			}
	
			// Constructors
			public Platform_PS4_Base() {} // 0x00000001871A46D0-0x00000001871A4730
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001871A4620-0x00000001871A46D0
			internal override IEnumerable<Axis> IterateAxes() => default; // 0x00000001871A44E0-0x00000001871A4580
			internal override IEnumerable<Button> IterateButtons() => default; // 0x00000001871A4580-0x00000001871A4620
			internal override bool IsElementIdentifierMapped(int elementIdentifierId) => default; // 0x00000001871A40F0-0x00000001871A44E0
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) {
				buttons = default;
				axes = default;
			} // 0x00000001871A3CB0-0x00000001871A40F0
			internal override AxisCalibrationData[] GetAxisCalibrationData() => default; // 0x00000001871A2AC0-0x00000001871A30E0
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) {
				axisRanges = default;
				axisInfos = default;
			} // 0x00000001871A30E0-0x00000001871A3820
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) {
				buttonInfos = default;
			} // 0x00000001871A3820-0x00000001871A3B80
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001871A3C20-0x00000001871A3CB0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
				axisRange = default;
				return default;
			} // 0x00000001871A3B80-0x00000001871A3C20
			public override object DeepClone() => default; // 0x00000001871A29F0-0x00000001871A2AC0
			internal override void CopyVars(Platform destination) {} // 0x00000001871A2860-0x00000001871A29F0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public sealed class Platform_PS4 : Platform_PS4_Base // TypeDefIndex: 3886
		{
			// Fields
			public Platform_PS4_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Platform> variants_base { get => default; } // 0x00000001871A53F0-0x00000001871A5450 
	
			// Constructors
			public Platform_PS4() {} // 0x00000001871A5350-0x00000001871A53F0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001871A5180-0x00000001871A5350
			public override object DeepClone() => default; // 0x00000001871A50E0-0x00000001871A5180
			internal override void CopyVars(Platform destination) {} // 0x00000001871A5010-0x00000001871A50E0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class Platform_NintendoSwitch_Base : Platform_Custom // TypeDefIndex: 3887
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get => default; } // 0x000000018719D0B0-0x000000018719D130 
			public override int assignedAxisCount { get => default; } // 0x000000018719D030-0x000000018719D0B0 
			internal override InputPlatform platform { get => default; } // 0x000000018719D2E0-0x000000018719D330 
			internal override Axis[] Axes { get => default; } // 0x000000018719CB90-0x000000018719CD60 
			internal override Button[] Buttons { get => default; } // 0x000000018719CDD0-0x000000018719CFC0 
			internal Axis[] Axes_orig { get => default; } // 0x000000018719CD60-0x000000018719CDD0 
			internal Button[] Buttons_orig { get => default; } // 0x000000018719CFC0-0x000000018719D030 
			internal override bool hasData { get => default; } // 0x000000018719D1A0-0x000000018719D250 
			internal override bool disabled { get => default; } // 0x000000018719D130-0x000000018719D1A0 
			internal override bool isAllowed { get => default; } // 0x000000018719D250-0x000000018719D2E0 
			internal override IList<Platform> variants_base { get => default; } // 0x000000018719D330-0x000000018719D380 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 3888
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
	
				// Properties
				internal override bool hasData { get => default; } // 0x000000018719AA60-0x000000018719AAE0 
				internal override bool isAllowed { get => default; } // 0x000000018719ACC0-0x000000018719AD50 
	
				// Constructors
				public MatchingCriteria() {} // 0x000000018719A3E0-0x000000018719A440
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) => default; // 0x00000001871988D0-0x0000000187198B60
				public override object DeepClone() => default; // 0x0000000187197C60-0x0000000187197D30
				internal override void CopyVars(MatchingCriteria_Base destination) {} // 0x0000000187197650-0x0000000187197760
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 3889
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get => default; } // 0x0000000187195450-0x00000001871954C0 
				public override int axisCount { get => default; } // 0x0000000187194EA0-0x0000000187194F10 
	
				// Constructors
				public Elements() {} // 0x0000000187194C20-0x0000000187194C80
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x0000000187194720-0x0000000187194940
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
					axisRange = default;
					return default;
				} // 0x0000000187193390-0x0000000187193680
				public override object DeepClone() => default; // 0x00000001871925E0-0x00000001871926B0
				internal override void CopyVars(Elements_Base destination) {} // 0x0000000187191B60-0x0000000187191C50
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 3890
			{
				// Constructors
				public Button() {} // 0x0000000187190220-0x0000000187190280
	
				// Methods
				public override object DeepClone() => default; // 0x000000018718FD80-0x000000018718FE50
				internal override void CopyVars(Platform_Custom.Element destination) {} // 0x000000018718F7C0-0x000000018718F840
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 3891
			{
				// Constructors
				public Axis() {} // 0x000000018718F240-0x000000018718F2A0
	
				// Methods
				public override object DeepClone() => default; // 0x000000018718E930-0x000000018718EA00
				internal override void CopyVars(Platform_Custom.Element destination) {} // 0x000000018718E5E0-0x000000018718E660
			}
	
			// Constructors
			public Platform_NintendoSwitch_Base() {} // 0x000000018719CB30-0x000000018719CB90
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x000000018719CA80-0x000000018719CB30
			internal override IEnumerable<Axis> IterateAxes() => default; // 0x000000018719C940-0x000000018719C9E0
			internal override IEnumerable<Button> IterateButtons() => default; // 0x000000018719C9E0-0x000000018719CA80
			internal override bool IsElementIdentifierMapped(int elementIdentifierId) => default; // 0x000000018719C540-0x000000018719C940
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) {
				buttons = default;
				axes = default;
			} // 0x000000018719C160-0x000000018719C540
			internal override AxisCalibrationData[] GetAxisCalibrationData() => default; // 0x000000018719B0C0-0x000000018719B770
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) {
				axisRanges = default;
				axisInfos = default;
			} // 0x000000018719B770-0x000000018719BCD0
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) {
				buttonInfos = default;
			} // 0x000000018719BCD0-0x000000018719C010
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x000000018719C0D0-0x000000018719C160
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
				axisRange = default;
				return default;
			} // 0x000000018719C010-0x000000018719C0D0
			public override object DeepClone() => default; // 0x000000018719AFF0-0x000000018719B0C0
			internal override void CopyVars(Platform destination) {} // 0x000000018719AE40-0x000000018719AFF0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public sealed class Platform_NintendoSwitch : Platform_NintendoSwitch_Base // TypeDefIndex: 3894
		{
			// Fields
			public Platform_NintendoSwitch_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Platform> variants_base { get => default; } // 0x000000018719D7A0-0x000000018719D800 
	
			// Constructors
			public Platform_NintendoSwitch() {} // 0x000000018719D700-0x000000018719D7A0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x000000018719D4F0-0x000000018719D700
			public override object DeepClone() => default; // 0x000000018719D450-0x000000018719D4F0
			internal override void CopyVars(Platform destination) {} // 0x000000018719D380-0x000000018719D450
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class Platform_InternalDriver_Base : Platform_Custom // TypeDefIndex: 3895
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get => default; } // 0x00000001869CB6E0-0x00000001869CB760 
			public override int assignedAxisCount { get => default; } // 0x00000001869CB660-0x00000001869CB6E0 
			internal override InputPlatform platform { get => default; } // 0x00000001869CB940-0x00000001869CB990 
			internal override Axis[] Axes { get => default; } // 0x00000001869CB1C0-0x00000001869CB3E0 
			internal override Button[] Buttons { get => default; } // 0x00000001869CB450-0x00000001869CB5F0 
			internal Axis[] Axes_orig { get => default; } // 0x00000001869CB3E0-0x00000001869CB450 
			internal Button[] Buttons_orig { get => default; } // 0x00000001869CB5F0-0x00000001869CB660 
			internal override bool hasData { get => default; } // 0x00000001869CB7D0-0x00000001869CB8B0 
			internal override bool disabled { get => default; } // 0x00000001869CB760-0x00000001869CB7D0 
			internal override bool isAllowed { get => default; } // 0x00000001869CB8B0-0x00000001869CB940 
			internal override IList<Platform> variants_base { get => default; } // 0x00000001869CB990-0x00000001869CB9E0 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 3896
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
				public VidPid[] vidPid; // 0x40
				public int hatCount; // 0x48
	
				// Properties
				internal override bool hasData { get => default; } // 0x00000001869C3AA0-0x00000001869C3B90 
				internal override bool isAllowed { get => default; } // 0x00000001869C3CF0-0x00000001869C3D70 
	
				// Constructors
				public MatchingCriteria() {} // 0x00000001869C3780-0x00000001869C37E0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) => default; // 0x00000001869C2B50-0x00000001869C2F40
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) {
					alternateMatched = default;
					return default;
				} // 0x00000001869C2600-0x00000001869C26B0
				public override object DeepClone() => default; // 0x00000001869C2360-0x00000001869C2430
				internal override void CopyVars(MatchingCriteria_Base destination) {} // 0x00000001869C2250-0x00000001869C2360
				private bool ProductNameMatches(string name) => default; // 0x00000001869C34A0-0x00000001869C35A0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 3897
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get => default; } // 0x00000001869BB4E0-0x00000001869BB550 
				public override int axisCount { get => default; } // 0x00000001869BB390-0x00000001869BB400 
	
				// Constructors
				public Elements() {} // 0x00000001869BB070-0x00000001869BB0D0
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001869BABE0-0x00000001869BAE00
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
					axisRange = default;
					return default;
				} // 0x00000001869B9DA0-0x00000001869BA160
				public override object DeepClone() => default; // 0x00000001869B98F0-0x00000001869B99C0
				internal override void CopyVars(Elements_Base destination) {} // 0x00000001869B92C0-0x00000001869B93B0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 3898
			{
				// Fields
				public int sourceHat; // 0x60
				public HatDirection sourceHatDirection; // 0x64
				public HatType sourceHatType; // 0x68
	
				// Constructors
				public Button() {} // 0x00000001869B4680-0x00000001869B46E0
	
				// Methods
				public override object DeepClone() => default; // 0x00000001869B3F50-0x00000001869B4020
				internal override void CopyVars(Platform_Custom.Element destination) {} // 0x00000001869B3BA0-0x00000001869B3C70
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 3899
			{
				// Fields
				public int sourceHat; // 0x68
				public AxisDirection sourceHatDirection; // 0x6C
				public HatType sourceHatType; // 0x70
				public AxisRange sourceHatRange; // 0x74
	
				// Constructors
				public Axis() {} // 0x00000001869B3990-0x00000001869B39F0
	
				// Methods
				public override object DeepClone() => default; // 0x00000001869B32F0-0x00000001869B33C0
				internal override void CopyVars(Platform_Custom.Element destination) {} // 0x00000001869B2C60-0x00000001869B2D30
			}
	
			// Constructors
			public Platform_InternalDriver_Base() {} // 0x00000001869CB160-0x00000001869CB1C0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001869CB0B0-0x00000001869CB160
			internal override IEnumerable<Axis> IterateAxes() => default; // 0x00000001869CAF70-0x00000001869CB010
			internal override IEnumerable<Button> IterateButtons() => default; // 0x00000001869CB010-0x00000001869CB0B0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId) => default; // 0x00000001869CABA0-0x00000001869CAF70
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) {
				buttons = default;
				axes = default;
			} // 0x00000001869CA450-0x00000001869CABA0
			internal override AxisCalibrationData[] GetAxisCalibrationData() => default; // 0x00000001869C92B0-0x00000001869C9970
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) {
				axisRanges = default;
				axisInfos = default;
			} // 0x00000001869C9970-0x00000001869C9F80
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) {
				buttonInfos = default;
			} // 0x00000001869C9F80-0x00000001869CA300
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001869CA3C0-0x00000001869CA450
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
				axisRange = default;
				return default;
			} // 0x00000001869CA300-0x00000001869CA3C0
			public override object DeepClone() => default; // 0x00000001869C91E0-0x00000001869C92B0
			internal override void CopyVars(Platform destination) {} // 0x00000001869C90A0-0x00000001869C91E0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public sealed class Platform_InternalDriver : Platform_InternalDriver_Base // TypeDefIndex: 3902
		{
			// Fields
			public Platform_InternalDriver_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Platform> variants_base { get => default; } // 0x00000001869CBE10-0x00000001869CBE70 
	
			// Constructors
			public Platform_InternalDriver() {} // 0x00000001869CBD70-0x00000001869CBE10
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001869CBB70-0x00000001869CBD70
			public override object DeepClone() => default; // 0x00000001869CBAD0-0x00000001869CBB70
			internal override void CopyVars(Platform destination) {} // 0x00000001869CB9E0-0x00000001869CBAD0
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class Platform_SDL2_Base : Platform // TypeDefIndex: 3903
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
	
			// Properties
			internal override InputPlatform platform { get => default; } // 0x00000001871A9BB0-0x00000001871A9C00 
			internal override bool hasData { get => default; } // 0x00000001871A9A70-0x00000001871A9B20 
			internal override bool disabled { get => default; } // 0x00000001871A9A00-0x00000001871A9A70 
			internal override bool isAllowed { get => default; } // 0x00000001871A9B20-0x00000001871A9BB0 
			internal Axis[] Axes_orig { get => default; } // 0x00000001871A9820-0x00000001871A9890 
			internal Button[] Buttons_orig { get => default; } // 0x00000001871A9890-0x00000001871A9900 
			internal override IList<Platform> variants_base { get => default; } // 0x00000001871A9C00-0x00000001871A9C50 
			public override int assignedButtonCount { get => default; } // 0x00000001871A9980-0x00000001871A9A00 
			public override int assignedAxisCount { get => default; } // 0x00000001871A9900-0x00000001871A9980 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class MatchingCriteria : MatchingCriteria_Base // TypeDefIndex: 3904
			{
				// Fields
				public int hatCount; // 0x28
				public bool manufacturer_useRegex; // 0x2C
				public bool productName_useRegex; // 0x2D
				public bool systemName_useRegex; // 0x2E
				public string[] manufacturer; // 0x30
				public string[] productName; // 0x38
				public string[] systemName; // 0x40
				public string[] productGUID; // 0x48
	
				// Properties
				internal override bool hasData { get => default; } // 0x000000018719A9A0-0x000000018719AA60 
				internal override bool isAllowed { get => default; } // 0x000000018719AAE0-0x000000018719AB50 
				internal override int alternateElementCount { get => default; } // 0x000000018719A580-0x000000018719A5D0 
	
				// Constructors
				public MatchingCriteria() {} // 0x000000018719A440-0x000000018719A4A0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) => default; // 0x00000001871998E0-0x0000000187199A60
				internal override ElementCount_Base GetAlternateElementCount(int index) => default; // 0x0000000187198330-0x0000000187198380
				internal override bool ElementCountsMatch(BridgedControllerHWInfo bridgedControllerHWInfo, out bool alternateMatched) {
					alternateMatched = default;
					return default;
				} // 0x0000000187198100-0x00000001871981B0
				private bool AnyNameMatches(BridgedControllerHWInfo bridgedControllerHWInfo) => default; // 0x00000001871965A0-0x0000000187196660
				private bool NameMatches(string name, string[] names, bool useRegex) => default; // 0x0000000187199A60-0x0000000187199C80
				public override object DeepClone() => default; // 0x0000000187197B90-0x0000000187197C60
				internal override void CopyVars(MatchingCriteria_Base destination) {} // 0x0000000187197760-0x00000001871978D0
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Elements : Elements_Base // TypeDefIndex: 3905
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get => default; } // 0x00000001871953E0-0x0000000187195450 
				public override int axisCount { get => default; } // 0x00000001871950D0-0x0000000187195140 
	
				// Constructors
				public Elements() {} // 0x0000000187194C80-0x0000000187194CE0
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x0000000187194550-0x0000000187194720
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
					axisRange = default;
					return default;
				} // 0x0000000187193950-0x0000000187193CD0
				public override object DeepClone() => default; // 0x0000000187192440-0x0000000187192510
				internal override void CopyVars(Elements_Base destination) {} // 0x0000000187191A60-0x0000000187191B60
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public abstract class Element : IDeepCloneable // TypeDefIndex: 3906
			{
				// Constructors
				protected Element() {} // 0x0000000187191940-0x00000001871919A0
	
				// Methods
				public abstract object DeepClone();
				protected virtual void ImportVars(Element source) {} // 0x00000001871918F0-0x0000000187191940
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public class Button : Element // TypeDefIndex: 3907
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceButton; // 0x18
				public int sourceAxis; // 0x1C
				public Pole sourceAxisPole; // 0x20
				public float axisDeadZone; // 0x24
				public int sourceHat; // 0x28
				public HatType sourceHatType; // 0x2C
				public HatDirection sourceHatDirection; // 0x30
				public bool requireMultipleButtons; // 0x34
				public int[] requiredButtons; // 0x38
				public bool ignoreIfButtonsActive; // 0x40
				public int[] ignoreIfButtonsActiveButtons; // 0x48
				public HardwareButtonInfo buttonInfo; // 0x50
	
				// Constructors
				public Button() {} // 0x00000001871903A0-0x0000000187190450
	
				// Methods
				public override object DeepClone() => default; // 0x000000018718FAC0-0x000000018718FB60
				protected override void ImportVars(Element source) {} // 0x000000018718FF20-0x0000000187190130
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public class Axis : Element // TypeDefIndex: 3908
			{
				// Fields
				public int elementIdentifier; // 0x10
				public HardwareElementSourceTypeWithHat sourceType; // 0x14
				public int sourceAxis; // 0x18
				public AxisRange sourceAxisRange; // 0x1C
				public bool invert; // 0x20
				public float axisDeadZone; // 0x24
				public bool calibrateAxis; // 0x28
				public float axisZero; // 0x2C
				public float axisMin; // 0x30
				public float axisMax; // 0x34
				public AxisCalibrationInfoEntry[] alternateCalibrations; // 0x38
				public HardwareAxisInfo axisInfo; // 0x40
				public int sourceButton; // 0x48
				public Pole buttonAxisContribution; // 0x4C
				public int sourceHat; // 0x50
				public AxisDirection sourceHatDirection; // 0x54
				public AxisRange sourceHatRange; // 0x58
	
				// Constructors
				public Axis() {} // 0x000000018718F070-0x000000018718F120
	
				// Methods
				public override object DeepClone() => default; // 0x000000018718E890-0x000000018718E930
				protected override void ImportVars(Element source) {} // 0x000000018718EDC0-0x000000018718EFE0
			}
	
			// Constructors
			public Platform_SDL2_Base() {} // 0x00000001871A97C0-0x00000001871A9820
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001871A9710-0x00000001871A97C0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId) => default; // 0x00000001871A9290-0x00000001871A95D0
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) {
				buttons = default;
				axes = default;
			} // 0x00000001871A8EF0-0x00000001871A9290
			internal override AxisCalibrationData[] GetAxisCalibrationData() => default; // 0x00000001871A7E30-0x00000001871A8530
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) {
				axisRanges = default;
				axisInfos = default;
			} // 0x00000001871A8530-0x00000001871A8B30
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) {
				buttonInfos = default;
			} // 0x00000001871A8B30-0x00000001871A8DC0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001871A8E60-0x00000001871A8EF0
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
				axisRange = default;
				return default;
			} // 0x00000001871A8DC0-0x00000001871A8E60
			internal IEnumerable<Axis> IterateAxes() => default; // 0x00000001871A95D0-0x00000001871A9670
			internal IEnumerable<Button> IterateButtons() => default; // 0x00000001871A9670-0x00000001871A9710
			public override object DeepClone() => default; // 0x00000001871A7D60-0x00000001871A7E30
			internal override void CopyVars(Platform destination) {} // 0x00000001871A7C70-0x00000001871A7D60
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public sealed class Platform_SDL2 : Platform_SDL2_Base // TypeDefIndex: 3911
		{
			// Fields
			public Platform_SDL2_Base[] variants; // 0x28
	
			// Properties
			internal override IList<Platform> variants_base { get => default; } // 0x00000001871AA080-0x00000001871AA0E0 
	
			// Constructors
			public Platform_SDL2() {} // 0x00000001871A9FE0-0x00000001871AA080
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001871A9E00-0x00000001871A9FE0
			public override object DeepClone() => default; // 0x00000001871A9D60-0x00000001871A9E00
			internal override void CopyVars(Platform destination) {} // 0x00000001871A9C50-0x00000001871A9D60
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public class Platform_WebGL_Base : Platform_Custom // TypeDefIndex: 3912
		{
			// Fields
			public MatchingCriteria matchingCriteria; // 0x18
			public Elements elements; // 0x20
			private Axis[] _axesOrigGame; // 0x28
			private Button[] _buttonsOrigGame; // 0x30
	
			// Properties
			public override int assignedButtonCount { get => default; } // 0x00000001871AC290-0x00000001871AC310 
			public override int assignedAxisCount { get => default; } // 0x00000001871AC210-0x00000001871AC290 
			internal override InputPlatform platform { get => default; } // 0x00000001871AC4C0-0x00000001871AC510 
			internal override Axis[] Axes { get => default; } // 0x00000001871ABDF0-0x00000001871ABF90 
			internal override Button[] Buttons { get => default; } // 0x00000001871AC000-0x00000001871AC1A0 
			internal Axis[] Axes_orig { get => default; } // 0x00000001871ABF90-0x00000001871AC000 
			internal Button[] Buttons_orig { get => default; } // 0x00000001871AC1A0-0x00000001871AC210 
			internal override bool hasData { get => default; } // 0x00000001871AC380-0x00000001871AC430 
			internal override bool disabled { get => default; } // 0x00000001871AC310-0x00000001871AC380 
			internal override bool isAllowed { get => default; } // 0x00000001871AC430-0x00000001871AC4C0 
			internal override IList<Platform> variants_base { get => default; } // 0x00000001871AC510-0x00000001871AC560 
	
			// Nested types
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class MatchingCriteria : Platform_Custom.MatchingCriteria // TypeDefIndex: 3913
			{
				// Fields
				public bool productName_useRegex; // 0x30
				public string[] productName; // 0x38
				public string[] productGUID; // 0x40
				public int[] mapping; // 0x48
				public ElementCount_Base[] elementCount; // 0x50
				public ClientInfo[] clientInfo; // 0x58
	
				// Properties
				internal override bool hasData { get => default; } // 0x000000018719A5D0-0x000000018719A720 
				internal override bool isAllowed { get => default; } // 0x000000018719AC40-0x000000018719ACC0 
	
				// Nested types
				[Serializable]
				public sealed class ClientInfo : IDeepCloneable // TypeDefIndex: 3914
				{
					// Fields
					public int browser; // 0x10
					public string browserVersionMin; // 0x18
					public string browserVersionMax; // 0x20
					public int os; // 0x28
					public string osVersionMin; // 0x30
					public string osVersionMax; // 0x38
	
					// Constructors
					public ClientInfo() {} // 0x0000000187190620-0x0000000187190680
	
					// Methods
					public object DeepClone() => default; // 0x0000000187190500-0x0000000187190620
				}
	
				// Constructors
				public MatchingCriteria() {} // 0x000000018719A380-0x000000018719A3E0
	
				// Methods
				internal override bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch) => default; // 0x0000000187198DC0-0x00000001871997E0
				private static bool CheckBrowserVersion(int browser, string versionMin, string versionMax, string[] currentVersion) => default; // 0x0000000187196660-0x0000000187196C70
				private static bool CheckOSVersion(string versionMin, string versionMax, string[] currentVersion) => default; // 0x0000000187196C70-0x0000000187197220
				public override object DeepClone() => default; // 0x0000000187197E00-0x0000000187197ED0
				internal override void CopyVars(MatchingCriteria_Base destination) {} // 0x0000000187197500-0x0000000187197650
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Elements : Platform_Custom.Elements // TypeDefIndex: 3915
			{
				// Fields
				public Axis[] axes; // 0x10
				public Button[] buttons; // 0x18
	
				// Properties
				public override int buttonCount { get => default; } // 0x0000000187195290-0x0000000187195300 
				public override int axisCount { get => default; } // 0x0000000187194F80-0x0000000187194FF0 
	
				// Constructors
				public Elements() {} // 0x0000000187194CE0-0x0000000187194D40
	
				// Methods
				internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x0000000187194110-0x0000000187194340
				internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
					axisRange = default;
					return default;
				} // 0x0000000187192DE0-0x00000001871930B0
				public override object DeepClone() => default; // 0x00000001871922D0-0x00000001871923A0
				internal override void CopyVars(Elements_Base destination) {} // 0x0000000187191D60-0x0000000187191E30
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Button : Platform_Custom.Button // TypeDefIndex: 3916
			{
				// Constructors
				public Button() {} // 0x0000000187190280-0x00000001871902E0
	
				// Methods
				public override object DeepClone() => default; // 0x000000018718F9F0-0x000000018718FAC0
				internal override void CopyVars(Platform_Custom.Element destination) {} // 0x000000018718F6C0-0x000000018718F740
			}
	
			[Serializable]
			[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
			public sealed class Axis : Platform_Custom.Axis // TypeDefIndex: 3917
			{
				// Constructors
				public Axis() {} // 0x000000018718F2A0-0x000000018718F300
	
				// Methods
				public override object DeepClone() => default; // 0x000000018718EAD0-0x000000018718EBA0
				internal override void CopyVars(Platform_Custom.Element destination) {} // 0x000000018718E560-0x000000018718E5E0
			}
	
			// Constructors
			public Platform_WebGL_Base() {} // 0x00000001871ABD90-0x00000001871ABDF0
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001871ABCB0-0x00000001871ABD90
			internal override IEnumerable<Axis> IterateAxes() => default; // 0x00000001871ABB70-0x00000001871ABC10
			internal override IEnumerable<Button> IterateButtons() => default; // 0x00000001871ABC10-0x00000001871ABCB0
			internal override bool IsElementIdentifierMapped(int elementIdentifierId) => default; // 0x00000001871AB830-0x00000001871ABB70
			internal override void GetGameElementIdentifierIdMappings(out int[] buttons, out int[] axes) {
				buttons = default;
				axes = default;
			} // 0x00000001871AB420-0x00000001871AB830
			internal override AxisCalibrationData[] GetAxisCalibrationData() => default; // 0x00000001871AA310-0x00000001871AA980
			internal override void GetAxisData(out AxisRange[] axisRanges, out HardwareAxisInfo[] axisInfos) {
				axisRanges = default;
				axisInfos = default;
			} // 0x00000001871AA980-0x00000001871AB030
			internal override void GetButtonData(out HardwareButtonInfo[] buttonInfos) {
				buttonInfos = default;
			} // 0x00000001871AB030-0x00000001871AB2D0
			internal override ControllerElementType GetEffectiveElementIdentifierType(ControllerElementIdentifier elementIdentifier) => default; // 0x00000001871AB390-0x00000001871AB420
			internal override bool GetEffectiveAxisRange(ControllerElementIdentifier elementIdentifier, out AxisRange axisRange) {
				axisRange = default;
				return default;
			} // 0x00000001871AB2D0-0x00000001871AB390
			public override object DeepClone() => default; // 0x00000001871AA240-0x00000001871AA310
			internal override void CopyVars(Platform destination) {} // 0x00000001871AA0E0-0x00000001871AA240
		}
	
		[Serializable]
		[CustomClassObfuscation] // 0x0000000189B09F50-0x0000000189B09F80
		public sealed class Platform_WebGL : Platform_WebGL_Base // TypeDefIndex: 3920
		{
			// Fields
			public Platform_WebGL_Base[] variants; // 0x38
	
			// Properties
			internal override IList<Platform> variants_base { get => default; } // 0x00000001871AC980-0x00000001871AC9E0 
	
			// Constructors
			public Platform_WebGL() {} // 0x00000001871AC8E0-0x00000001871AC980
	
			// Methods
			internal override bool Matches(BridgedControllerHWInfo BridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
				variantIndex = default;
				platformMap = default;
				return default;
			} // 0x00000001871AC6D0-0x00000001871AC8E0
			public override object DeepClone() => default; // 0x00000001871AC630-0x00000001871AC6D0
			internal override void CopyVars(Platform destination) {} // 0x00000001871AC560-0x00000001871AC630
		}
	
		// Constructors
		public HardwareJoystickMap() {} // 0x00000001869BF670-0x00000001869C0120
		public HardwareJoystickMap(HardwareJoystickMap source) {} // 0x00000001869C0120-0x00000001869C0E10
	
		// Methods
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public string[] GetElementIdentifierNames() => default; // 0x00000001869BDDD0-0x00000001869BDF50
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public int[] GetElementIdentifierIds() => default; // 0x00000001869BD770-0x00000001869BD900
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public ControllerElementIdentifier GetElementIdentifier(int id) => default; // 0x00000001869BDF50-0x00000001869BE030
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public bool ContainsElementIdentifier(int id) => default; // 0x00000001869BBCE0-0x00000001869BBD60
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public int GetElementIdentifierInfo(ControllerElementType type, out string[] names, out int[] ids) {
			names = default;
			ids = default;
			return default;
		} // 0x00000001869BD900-0x00000001869BDDD0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		public int GetMappableElementIdentifierInfo(out string[] names, out int[] ids) {
			names = default;
			ids = default;
			return default;
		} // 0x00000001869BE1D0-0x00000001869BE680
		internal HardwareJoystickMap Clone() => default; // 0x00000001869BBC60-0x00000001869BBCE0
		internal int IndexOfElementIdentifier(int id) => default; // 0x00000001869BEBB0-0x00000001869BECD0
		internal ControllerElementType GetEffectiveElementIdentifierType(HardwareControllerMapIdentifier hardwareMapIdentifier, int elementIdentifierId, bool isDefaultMap) => default; // 0x00000001869BD640-0x00000001869BD770
		internal bool GetEffectiveAxisRange(HardwareControllerMapIdentifier hardwareMapIdentifier, int elementIdentifierId, bool isDefaultMap, out AxisRange axisRange) {
			axisRange = default;
			return default;
		} // 0x00000001869BD4B0-0x00000001869BD640
		internal void GetElementIdentifiersForControllerElements(HardwareControllerMapIdentifier hardwareMapIdentifier, bool isDefaultMap, out int[] buttons, out int[] axes) {
			buttons = default;
			axes = default;
		} // 0x00000001869BE030-0x00000001869BE1D0
		internal static bool Matches(Platform platform, BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, out int variantIndex, out Platform platformMap) {
			variantIndex = default;
			platformMap = default;
			return default;
		} // 0x00000001869BECD0-0x00000001869BEDA0
		internal bool Matches(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex, out Platform platformMap) {
			actualInputPlatform = default;
			variantIndex = default;
			platformMap = default;
			return default;
		} // 0x00000001869BEDA0-0x00000001869BF550
		internal HardwareJoystickMap_InputManager GetDefaultHardwareJoystickMap_InputManager(InputSource inputSource) => default; // 0x00000001869BD0D0-0x00000001869BD4B0
		internal string[] GetTemplateGuidsOrig() => default; // 0x00000001869BEB50-0x00000001869BEBB0
		IControllerElementIdentifierCommon_Internal IHardwareControllerMap_Internal.GetElementIdentifier(int id) => default; // 0x00000001869BF550-0x00000001869BF5D0
		private Platform_Fallback_Base FindFallbackMatch(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) {
			actualInputPlatform = default;
			variantIndex = default;
			return default;
		} // 0x00000001869BC460-0x00000001869BCC40
		private Platform_Fallback_Base FindFallbackMap(InputSource inputSource, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) {
			actualInputPlatform = default;
			variantIndex = default;
			return default;
		} // 0x00000001869BBD60-0x00000001869BC460
		private Platform_SDL2_Base FindSDL2Match(BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) {
			actualInputPlatform = default;
			variantIndex = default;
			return default;
		} // 0x00000001869BCEB0-0x00000001869BD0D0
		private Platform_SDL2_Base FindSDL2Map(InputSource inputSource, bool isDefaultMap, out InputPlatform actualInputPlatform, out int variantIndex) {
			actualInputPlatform = default;
			variantIndex = default;
			return default;
		} // 0x00000001869BCC40-0x00000001869BCEB0
		private T TryGetFirstValidMap<T>(T mainMap, bool isDefaultMap, ref InputPlatform actualInputPlatform, out int variantIndex)
			where T : Platform {
			variantIndex = default;
			return default;
		}
		private T TryGetFirstMatchingMap<T>(T mainMap, BridgedControllerHWInfo bridgedControllerHWInfo, bool strictMatch, bool isDefaultMap, ref InputPlatform actualInputPlatform, out int variantIndex)
			where T : Platform {
			variantIndex = default;
			return default;
		}
		private T GetUniversalDefaultMap<T>(out InputPlatform actualInputPlatform, out int variantIndex)
			where T : Platform {
			actualInputPlatform = default;
			variantIndex = default;
			return default;
		}
		private T GetUniversalDefaultMapRoot<T>(System.Type type, out InputPlatform actualInputPlatform)
			where T : Platform {
			actualInputPlatform = default;
			return default;
		}
		private Platform GetSpecificPlatformMap(HardwareControllerMapIdentifier hardwareMapIdentifier) => default; // 0x00000001869BE680-0x00000001869BE710
		private Platform GetSpecificPlatformRoot(InputPlatform exactInputPlatform) => default; // 0x00000001869BE710-0x00000001869BEB50
	}
}
