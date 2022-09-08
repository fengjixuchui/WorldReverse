/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired
{
	public struct ElementAssignment // TypeDefIndex: 3481
	{
		// Fields
		public ElementAssignmentType type; // 0x00
		public int elementMapId; // 0x04
		public int elementIdentifierId; // 0x08
		public AxisRange axisRange; // 0x0C
		public KeyCode keyboardKey; // 0x10
		public ModifierKeyFlags modifierKeyFlags; // 0x14
		public int actionId; // 0x18
		public Pole axisContribution; // 0x1C
		public bool invert; // 0x20
	
		// Constructors
		public ElementAssignment(ElementAssignmentType elementAssignmentType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId) {
			type = default;
			this.elementMapId = default;
			this.elementIdentifierId = default;
			this.axisRange = default;
			this.keyboardKey = default;
			this.modifierKeyFlags = default;
			this.actionId = default;
			this.axisContribution = default;
			this.invert = default;
		} // 0x000000018582BFE0-0x000000018582C0E0
		public ElementAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert, int elementMapId) {
			type = default;
			this.elementMapId = default;
			this.elementIdentifierId = default;
			this.axisRange = default;
			this.keyboardKey = default;
			this.modifierKeyFlags = default;
			this.actionId = default;
			this.axisContribution = default;
			this.invert = default;
		} // 0x000000018582C0E0-0x000000018582C1C0
		public ElementAssignment(ControllerType controllerType, ControllerElementType elementType, int elementIdentifierId, AxisRange axisRange, KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution, bool invert) {
			type = default;
			elementMapId = default;
			this.elementIdentifierId = default;
			this.axisRange = default;
			this.keyboardKey = default;
			this.modifierKeyFlags = default;
			this.actionId = default;
			this.axisContribution = default;
			this.invert = default;
		} // 0x000000018582BF10-0x000000018582BFE0
		public ElementAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution) {
			type = default;
			elementMapId = default;
			elementIdentifierId = default;
			axisRange = default;
			this.keyboardKey = default;
			this.modifierKeyFlags = default;
			this.actionId = default;
			this.axisContribution = default;
			invert = default;
		} // 0x000000018582C1C0-0x000000018582C250
	
		// Methods
		public static ElementAssignment KeyboardKeyAssignment(KeyCode keyboardKey, ModifierKeyFlags modifierKeyFlags, int actionId, Pole axisContribution) => default; // 0x000000018582B880-0x000000018582BDF0
		public ElementAssignmentConflictCheck ToElementAssignmentConflictCheck() => default; // 0x000000018582BDF0-0x000000018582BF10
	}
}
