/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoJoypadUIModule : MonoBehaviour // TypeDefIndex: 30669
	{
		// Fields
		// [Header] // 0x00000001897B9260-0x00000001897B92D0
		[SerializeField] // 0x00000001897B9260-0x00000001897B92D0
		// [Tooltip] // 0x00000001897B9260-0x00000001897B92D0
		protected bool _isFocus; // 0x18
		// [Header] // 0x00000001897CA170-0x00000001897CA1B0
		[SerializeField] // 0x00000001897CA170-0x00000001897CA1B0
		protected UINavTargetConfig[] _navDirTargets; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected string _moduleName; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected uint[] _priorityLevels; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected bool _focusOnActive; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		protected GameObject[] _activeObjects; // 0x40
		protected HashSet<GameObject> _activeObjHashSet; // 0x48
		protected MonoJoypadUIModule _parentModule; // 0x58
		protected bool _transferNavigateCmd; // 0x60
	
		// Properties
		public string moduleName { /* [XID] */ /* 0x00000001898151F0-0x0000000189815210 */ get => default; /* [XID] */ /* 0x000000018981CC30-0x000000018981CC50 */ set {} } // 0x0000000183F90D90-0x0000000183F90E30 0x0000000183F90ED0-0x0000000183F90F80
		public uint[] priorityLevels { /* [XID] */ /* 0x0000000189824050-0x0000000189824070 */ get => default; } // 0x0000000183F90E30-0x0000000183F90ED0 
		public GameObject[] activeObjects { /* [XID] */ /* 0x000000018982BA50-0x000000018982BA70 */ get => default; } // 0x0000000183F90B10-0x0000000183F90BB0 
		public HashSet<GameObject> activeObjHashSet { /* [XID] */ /* 0x0000000189833050-0x0000000189833070 */ get => default; } // 0x0000000183F90A70-0x0000000183F90B10 
		public bool isFocus { /* [XID] */ /* 0x000000018983A4E0-0x000000018983A500 */ get => default; } // 0x0000000183F90CF0-0x0000000183F90D90 
		public bool hasContext { /* [XID] */ /* 0x0000000189841AE0-0x0000000189841B00 */ get => default; } // 0x0000000183F90C10-0x0000000183F90CF0 
		public BaseContext context { /* [XID] */ /* 0x0000000189848FD0-0x0000000189849010 */ get; /* [XID] */ /* 0x00000001898532F0-0x0000000189853330 */ protected set; } // 0x0000000183F90BB0-0x0000000183F90C10 0x0000000183F8EBA0-0x0000000183F8EC00
	
		// Nested types
		[Serializable]
		public struct UINavTargetConfig // TypeDefIndex: 30670
		{
			// Fields
			public JoypadCrossNavDir navDir; // 0x00
			public MonoJoypadUIModule navTarget; // 0x08
	
			// Constructors
			public UINavTargetConfig(JoypadCrossNavDir navDir) {
				this.navDir = default;
				navTarget = default;
			} // 0x0000000183FA0750-0x0000000183FA07E0
			public UINavTargetConfig(JoypadCrossNavDir navDir, MonoJoypadUIModule navTarget) {
				this.navDir = default;
				this.navTarget = default;
			} // 0x0000000183FA06E0-0x0000000183FA0750
		}
	
		// Constructors
		public MonoJoypadUIModule() {} // 0x0000000183F907F0-0x0000000183F90A70
	
		// Methods
		// [XID] // 0x00000001897FEC30-0x00000001897FEC50
		protected static bool IsUsingJoypad() => default; // 0x0000000183F8F5A0-0x0000000183F8F6B0
		// [XID] // 0x0000000189806370-0x0000000189806390
		protected static int NavDirToTargetIndex(JoypadCrossNavDir navDir) => default; // 0x0000000183F8E1E0-0x0000000183F8E280
		// [XID] // 0x000000018980DA10-0x000000018980DA30
		protected static bool GetNavDir(ContextNavDirConfig[] navDirArr, ContextEventType context, out JoypadCrossNavDir navDir) {
			navDir = default;
			return default;
		} // 0x0000000183F8EC00-0x0000000183F8ED20
		// [XID] // 0x000000018985D670-0x000000018985D690
		private void Awake() {} // 0x0000000183F8E130-0x0000000183F8E1E0
		// [XID] // 0x0000000189865010-0x0000000189865030
		protected virtual void OnEnable() {} // 0x0000000183F90050-0x0000000183F90110
		// [XID] // 0x000000018986C590-0x000000018986C5B0
		protected virtual void OnDisable() {} // 0x0000000183F8FF70-0x0000000183F90050
		// [XID] // 0x00000001898739E0-0x0000000189873A00
		protected virtual void OnDestroy() {} // 0x0000000183F8FE50-0x0000000183F8FF70
		// [XID] // 0x000000018987B430-0x000000018987B450
		public virtual void SetBaseContext(BaseContext context, bool registerToContext = false /* Metadata: 0x00B11429 */) {} // 0x0000000183F903F0-0x0000000183F90500
		// [XID] // 0x000000018972A800-0x000000018972A820
		public virtual void ClearBaseContext() {} // 0x0000000183F8E5D0-0x0000000183F8E6B0
		// [XID] // 0x0000000189889D80-0x0000000189889DA0
		protected virtual JoypadCrossNavDir ContextToNavDir(ContextEventType context) => default; // 0x0000000183F8F2A0-0x0000000183F8F350
		// [XID] // 0x0000000189891220-0x0000000189891240
		protected virtual void Init() {} // 0x0000000183F8E6B0-0x0000000183F8E810
		// [XID] // 0x0000000189898830-0x0000000189898850
		public void SetParentModule(MonoJoypadUIModule parentModule, bool transferNavigate) {} // 0x0000000183F90720-0x0000000183F907F0
		// [XID] // 0x000000018989FA70-0x000000018989FA90
		public virtual void SetNavigateTarget(JoypadCrossNavDir navDir, MonoJoypadUIModule targetModule) {} // 0x0000000183F90610-0x0000000183F90720
		// [XID] // 0x00000001898A74A0-0x00000001898A74C0
		public virtual void NavigateFromTarget(MonoJoypadUIModule source, JoypadCrossNavDir fromDir, Vector3 navScreenPos, int sourceIndex) {} // 0x0000000183F8F6B0-0x0000000183F8F800
		// [XID] // 0x00000001898AEE80-0x00000001898AEEA0
		public virtual bool NavigateToTarget(JoypadCrossNavDir toDir, int sourceIndex) => default; // 0x0000000183F8F800-0x0000000183F8FBE0
		// [XID] // 0x00000001898B6290-0x00000001898B62B0
		protected virtual void HandleNavigateFromTarget(MonoJoypadUIModule source, JoypadCrossNavDir fromDir, Vector3 navScreenPos) {} // 0x0000000183F8E280-0x0000000183F8E3D0
		// [XID] // 0x00000001898BDB60-0x00000001898BDB80
		public virtual void HandleNavigateToTarget(MonoJoypadUIModule navTarget) {} // 0x0000000183F8F0B0-0x0000000183F8F180
		// [XID] // 0x00000001898C5400-0x00000001898C5420
		protected void HandleNavigateObjectAcitve(GameObject[] deactiveObjs, GameObject[] activeObjs) {} // 0x0000000183F8FBE0-0x0000000183F8FE50
		// [XID] // 0x00000001898CC8F0-0x00000001898CC910
		protected void SetManageObjectActive(bool active) {} // 0x0000000183F8E810-0x0000000183F8E950
		// [XID] // 0x00000001898D4360-0x00000001898D4380
		public virtual bool HandleInputAction(InputActionEvent actionEvent) => default; // 0x0000000183F8ED20-0x0000000183F8EE30
		// [XID] // 0x00000001898DBB40-0x00000001898DBB60
		public virtual bool HandleNavigateAction(InputActionEvent actionEvent, int sourceIndex = 0 /* Metadata: 0x00B1142A */) => default; // 0x0000000183F8EE30-0x0000000183F8F0B0
		// [XID] // 0x00000001898E3720-0x00000001898E3740
		public virtual void OnSetActive(bool active) {} // 0x0000000183F90110-0x0000000183F90220
		// [XID] // 0x00000001898EB3C0-0x00000001898EB3E0
		public virtual void SetFocus(bool focus, bool activateObj = true /* Metadata: 0x00B1142E */, bool force = false /* Metadata: 0x00B1142F */) {} // 0x0000000183F90500-0x0000000183F90610
		// [XID] // 0x00000001898F2B00-0x00000001898F2B20
		protected virtual void OnFocus(bool activateObj) {} // 0x0000000183F8E3D0-0x0000000183F8E5D0
		// [XID] // 0x00000001898FA270-0x00000001898FA290
		protected virtual void OnLostFocus(bool activateObj) {} // 0x0000000183F90220-0x0000000183F903F0
		// [XID] // 0x0000000189901C40-0x0000000189901C60
		private void InternalFocusOnContext() {} // 0x0000000183F8F350-0x0000000183F8F5A0
		// [XID] // 0x00000001899094B0-0x00000001899094D0
		private void InternalLostFocusOnContext() {} // 0x0000000183F8E950-0x0000000183F8EBA0
		// [XID] // 0x00000001899108C0-0x00000001899108E0
		protected virtual Vector3 GetCrossNavRefPosition() => default; // 0x0000000183F8F180-0x0000000183F8F2A0
	}
}
