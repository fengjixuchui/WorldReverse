/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
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
	public abstract class ControllerMap // TypeDefIndex: 4132
	{
		// Fields
		protected int _id; // 0x10
		protected int _sourceMapId; // 0x14
		protected int _categoryId; // 0x18
		protected int _layoutId; // 0x1C
		protected string _name; // 0x20
		protected Guid _hardwareGuid; // 0x28
		protected bool _enabled; // 0x38
		internal readonly int znFtIaPrJLvdjPGCwXFaaAeLKcr; // 0x3C
		private readonly AList<ActionElementMap> yaioNhAHmyifoDnqDTMwJZLzxdsc; // 0x40
		private readonly ReadOnlyCollection<ActionElementMap> sVZWYsJWzeSJLdFSRckFcuHWGKT; // 0x48
		private readonly AList<ActionElementMap> DamcbcIjPKsafMMaNHJXgqqYQUk; // 0x50
		private readonly ReadOnlyCollection<ActionElementMap> PDmRtYnsUPmgAQFXiwnKKgQeTnS; // 0x58
		protected int _playerId; // 0x60
		protected int _controllerId; // 0x64
		protected ControllerType _controllerType; // 0x68
		private static int yyRdqIEdvRRWoOnhAbeUyuGapvs; // 0x00
	
		// Properties
		private static int nextUid { get; } // 0x0000000185E810B0-0x0000000185E811C0 
		public int id { get; } // 0x0000000185E80F10-0x0000000185E80FE0 
		public int sourceMapId { get; internal set; } // 0x0000000185E812B0-0x0000000185E81380 0x0000000185E81A50-0x0000000185E81AB0
		public int categoryId { get; internal set; } // 0x0000000185E80970-0x0000000185E80A40 0x0000000185E817A0-0x0000000185E81800
		public int layoutId { get; } // 0x0000000185E80FE0-0x0000000185E810B0 
		internal string name { get; set; } // 0x0000000185E81990-0x0000000185E819F0
		public Guid hardwareGuid { get; internal set; } // 0x0000000185E80DF0-0x0000000185E80F10 0x0000000185E81920-0x0000000185E81990
		public bool enabled { get; set; } // 0x0000000185E80D20-0x0000000185E80DF0 0x0000000185E818C0-0x0000000185E81920
		public int playerId { get; internal set; } // 0x0000000185E811C0-0x0000000185E812B0 0x0000000185E819F0-0x0000000185E81A50
		public int controllerId { get; internal set; } // 0x0000000185E80A40-0x0000000185E80B10 0x0000000185E81800-0x0000000185E81860
		public Controller controller { get; } // 0x0000000185E80BE0-0x0000000185E80D20 
		public ControllerType controllerType { get; internal set; } // 0x0000000185E80B10-0x0000000185E80BE0 0x0000000185E81860-0x0000000185E818C0
		public int buttonMapCount { get; } // 0x0000000185E80890-0x0000000185E80970 
		public IList<ActionElementMap> AllMaps { get; } // 0x0000000185E80670-0x0000000185E80750 
		public IList<ActionElementMap> ButtonMaps { get; } // 0x0000000185E80750-0x0000000185E80830 
		internal AList<ActionElementMap> ButtonMaps_orig { get; } // 0x0000000185E80830-0x0000000185E80890 
	
		// Nested types
		private class BYWhcxyfFJAbsgDmIQLeLndiLqre : IComparer<ActionElementMap> // TypeDefIndex: 4133
		{
			// Fields
			public static BYWhcxyfFJAbsgDmIQLeLndiLqre LDwDTzcqSaJaAJzktFPjtpIxftC; // 0x00
	
			// Properties
			public static BYWhcxyfFJAbsgDmIQLeLndiLqre ArjUpFKKDkOtOldZpRLmmMUFaxP { get => default; } // 0x0000000185E701E0-0x0000000185E702B0 
	
			// Constructors
			public BYWhcxyfFJAbsgDmIQLeLndiLqre() {} // 0x0000000185E70180-0x0000000185E701E0
	
			// Methods
			public int Compare(ActionElementMap x, ActionElementMap y) => default; // 0x0000000185E6FF50-0x0000000185E70180
		}
	
		// Constructors
		public ControllerMap() {} // 0x0000000185E804D0-0x0000000185E80670
		static ControllerMap() {} // 0x0000000185E80480-0x0000000185E804D0
	
		// Methods
		public virtual bool ContainsAction(int actionId) => default; // 0x0000000185E7B8B0-0x0000000185E7BA60
		public bool ContainsElementMap(ActionElementMap elementMap) => default; // 0x0000000185E7BA60-0x0000000185E7BC20
		public bool ContainsElementMap(int elementMapId) => default; // 0x0000000185E7BC20-0x0000000185E7BDB0
		public bool ReplaceOrCreateElementMap(ElementAssignment elementAssignment, out ActionElementMap result) {
			result = default;
			return default;
		} // 0x0000000185E7FF50-0x0000000185E800D0
		public bool CreateElementMap(ElementAssignment elementAssignment) => default; // 0x0000000185E7BDB0-0x0000000185E7BED0
		public bool CreateElementMap(ElementAssignment elementAssignment, out ActionElementMap result) {
			result = default;
			return default;
		} // 0x0000000185E7C300-0x0000000185E7C4F0
		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3, out ActionElementMap result) {
			result = default;
			return default;
		} // 0x0000000185E7C4F0-0x0000000185E7C6B0
		public bool CreateElementMap(int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags, out ActionElementMap result) {
			result = default;
			return default;
		} // 0x0000000185E7BED0-0x0000000185E7C080
		public virtual bool CreateElementMap(int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result) {
			result = default;
			return default;
		} // 0x0000000185E7C080-0x0000000185E7C300
		public bool ReplaceElementMap(ElementAssignment elementAssignment, out ActionElementMap result) {
			result = default;
			return default;
		} // 0x0000000185E7F560-0x0000000185E7F790
		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKey modifierKey1, ModifierKey modifierKey2, ModifierKey modifierKey3, out ActionElementMap result) {
			result = default;
			return default;
		} // 0x0000000185E7F890-0x0000000185E7FC00
		public bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, KeyCode keyCode, ModifierKeyFlags modifierKeyFlags, out ActionElementMap result) {
			result = default;
			return default;
		} // 0x0000000185E7F790-0x0000000185E7F890
		public virtual bool ReplaceElementMap(int elementMapId, int actionId, Pole axisContribution, int elementIdentifierId, ControllerElementType elementType, AxisRange axisRange, bool invert, out ActionElementMap result) {
			result = default;
			return default;
		} // 0x0000000185E7FC00-0x0000000185E7FF50
		public virtual bool DeleteElementMap(int elementMapId) => default; // 0x0000000185E7C7D0-0x0000000185E7C8C0
		public virtual ActionElementMap GetElementMap(int elementMapId) => default; // 0x0000000185E7DB10-0x0000000185E7DC90
		public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId) => default; // 0x0000000185E7CF10-0x0000000185E7CF90
		public IEnumerable<ActionElementMap> ElementMapsWithAction(int actionId, bool skipDisabledMaps) => default; // 0x0000000185E7CF90-0x0000000185E7D050
		public virtual ActionElementMap GetFirstElementMapWithAction(int actionId, bool skipDisabledMaps) => default; // 0x0000000185E7E2B0-0x0000000185E7E4B0
		public ActionElementMap GetFirstElementMapWithElementTarget(ControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps) => default; // 0x0000000185E7E600-0x0000000185E7E750
		public ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget elementTarget, int actionId, bool skipDisabledMaps) => default; // 0x0000000185E7E4B0-0x0000000185E7E600
		public virtual void ClearElementMaps() {} // 0x0000000185E7B7B0-0x0000000185E7B8B0
		public ActionElementMap GetFirstButtonMapWithAction(int actionId) => default; // 0x0000000185E7E230-0x0000000185E7E2B0
		public ActionElementMap GetFirstButtonMapWithAction(int actionId, bool skipDisabledMaps) => default; // 0x0000000185E7DEC0-0x0000000185E7E230
		public bool DoesElementAssignmentConflict(ActionElementMap actionElementMap) => default; // 0x0000000185E7CB00-0x0000000185E7CB90
		public virtual bool DoesElementAssignmentConflict(ActionElementMap actionElementMap, bool skipDisabledMaps) => default; // 0x0000000185E7C8C0-0x0000000185E7CB00
		public virtual bool DoesElementAssignmentConflict(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) => default; // 0x0000000185E7CB90-0x0000000185E7CE30
		public virtual IEnumerable<ElementAssignmentConflictInfo> ElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) => default; // 0x0000000185E7CE30-0x0000000185E7CF10
		public virtual int RemoveElementAssignmentConflicts(ElementAssignmentConflictCheck conflictCheck, bool skipDisabledMaps) => default; // 0x0000000185E7F1F0-0x0000000185E7F560
		public string ToXmlString() => default; // 0x0000000185E800D0-0x0000000185E802B0
		internal virtual bool AddActionMapping_BeforeBake(ActionElementMap param_000089d8) => default; // 0x0000000185E7B320-0x0000000185E7B420
		internal int IziPXwDvTqTtXGnCEcUeHXXLzMYe(int param_000089d9) => default; // 0x0000000185E7EF80-0x0000000185E7F070
		internal virtual int GetElementMapsWithAction(int param_000089da, bool param_000089db, List<ActionElementMap> param_000089dc, bool param_000089dd) => default; // 0x0000000185E7DC90-0x0000000185E7DEC0
		internal virtual ActionElementMap GetFirstElementMapWithElementTarget(IControllerElementTarget param_000089de, bool param_000089df, int param_000089e0, bool param_000089e1, out bool param_000089e2) {
			param_000089e2 = default;
			return default;
		} // 0x0000000185E7E750-0x0000000185E7EA50
		internal void gjbIScrKvQatHDCNOLNXFZCFGhv(int param_000089e3, ControllerElementType param_000089e4) {} // 0x0000000185E81380-0x0000000185E814E0
		internal virtual bool AddElementMap(ActionElementMap param_000089e5) => default; // 0x0000000185E7B420-0x0000000185E7B510
		internal bool BTcXIhKWEqfxufBlemcfpGLBatp(IControllerElementTarget param_000089e6) => default; // 0x0000000185E7B5D0-0x0000000185E7B6D0
		internal bool qvdkeukHWHtqCAvrLHBkNbdqXIz(string param_000089e7) => default; // 0x0000000185E815C0-0x0000000185E817A0
		internal void ZXTTERTmYRGjWpTQPsXGmIFjEPp(ActionElementMap param_000089e8) {} // 0x0000000185E803A0-0x0000000185E80480
		internal void BDKELfBOvrxXEfPJDRLKPineuSg(int param_000089e9) {} // 0x0000000185E7B510-0x0000000185E7B5D0
		internal static void luomRJHoFJehByGwbbSySSuKiyS(ActionElementMap param_000089ea, int param_000089eb, Pole param_000089ec, int param_000089ed, ControllerElementType param_000089ee, AxisRange param_000089ef, bool param_000089f0) {} // 0x0000000185E814E0-0x0000000185E815C0
		protected void BakeElementMap(ActionElementMap map) {} // 0x0000000185E7B6D0-0x0000000185E7B7B0
		internal virtual bool Import(SerializedObject param_000089f2) => default; // 0x0000000185E7EB00-0x0000000185E7EF80
		internal virtual void ExportDataToSerializedObject(SerializedObject param_000089f3) {} // 0x0000000185E7D050-0x0000000185E7DB10
		private bool NazMgzUnvggfOsDycmqIQvTPcxX(ControllerElementType param_000089f4) => default; // 0x0000000185E7F190-0x0000000185E7F1F0
		private void IQnrTBWpoLyVgqkOrYmtBIHQBJf(int param_000089f5, int param_000089f6) {} // 0x0000000185E7EA50-0x0000000185E7EB00
		private void zMHDgeCdkJmjfDLdekpvLhdOLmH(ActionElementMap param_000089f7) {} // 0x0000000185E81B70-0x0000000185E81C10
		private int XZdWmnOQkFFIYvxePtoqlDhYOpX(int param_000089f8) => default; // 0x0000000185E802B0-0x0000000185E803A0
		private SerializedObject wGWQXZtIQyRkZMrIKWqTSlWZlQY() => default; // 0x0000000185E81AB0-0x0000000185E81B70
		internal static ControllerMap MdLShCgeucAqBomYFlMaHVWokJC(ControllerType param_000089f9) => default; // 0x0000000185E7F070-0x0000000185E7F190
		public static ControllerMap CreateFromXml(ControllerType controllerType, string xmlString) => default; // 0x0000000185E7C6B0-0x0000000185E7C7D0
	}
}
