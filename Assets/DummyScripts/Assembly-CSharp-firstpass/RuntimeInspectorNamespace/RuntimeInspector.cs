/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public class RuntimeInspector : SkinnedWindow // TypeDefIndex: 9972
	{
		// Fields
		private const string POOL_OBJECT_NAME = "RuntimeInspectorPool"; // Metadata: 0x00AE6DE4
		private object m_inspectedObject; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float refreshInterval; // 0x30
		private float nextRefreshTime; // 0x34
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_debugMode; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_exposePrivateFields; // 0x39
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_exposePublicFields; // 0x3A
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_exposePrivateProperties; // 0x3B
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_exposePublicProperties; // 0x3C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_arrayIndicesStartAtOne; // 0x3D
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_useTitleCaseNaming; // 0x3E
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int m_nestLimit; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int poolCapacity; // 0x44
		private Transform poolParent; // 0x48
		private static int aliveInspectors; // 0x00
		private static Dictionary<System.Type, List<InspectorField>> drawersPool; // 0x08
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RuntimeHierarchy m_connectedHierarchy; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RuntimeInspectorSettings[] settings; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect scrollView; // 0x60
		private RectTransform drawArea; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image background; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image scrollbar; // 0x78
		private InspectorField currentDrawer; // 0x80
		private bool inspectLock; // 0x88
		private bool isDirty; // 0x89
		public InspectedObjectChangingDelegate OnInspectedObjectChanging; // 0x90
		private Dictionary<System.Type, InspectorField> typeToDrawer; // 0x98
		private Dictionary<System.Type, InspectorField> typeToReferenceDrawer; // 0xA0
		private List<VariableSet> hiddenVariables; // 0xA8
		private List<VariableSet> exposedVariables; // 0xB0
	
		// Properties
		public object InspectedObject { /* [XID] */ /* 0x000000018983E870-0x000000018983E890 */ get => default; } // 0x000000018674E0A0-0x000000018674E140 
		public bool IsBound { /* [XID] */ /* 0x0000000189845F20-0x0000000189845F40 */ get => default; } // 0x000000018674E140-0x000000018674E210 
		public bool DebugMode { /* [XID] */ /* 0x000000018984D5E0-0x000000018984D600 */ get => default; /* [XID] */ /* 0x00000001898545F0-0x0000000189854610 */ set {} } // 0x000000018674DD80-0x000000018674DE20 0x000000018674E4C0-0x000000018674E580
		public bool ExposePrivateFields { /* [XID] */ /* 0x000000018985BF60-0x000000018985BF80 */ get => default; /* [XID] */ /* 0x0000000189665E00-0x0000000189665E20 */ set {} } // 0x000000018674DE20-0x000000018674DEC0 0x000000018674E580-0x000000018674E640
		public bool ExposePublicFields { /* [XID] */ /* 0x000000018966D5B0-0x000000018966D5D0 */ get => default; /* [XID] */ /* 0x0000000189871EF0-0x0000000189871F10 */ set {} } // 0x000000018674DF60-0x000000018674E000 0x000000018674E700-0x000000018674E7C0
		public bool ExposePrivateProperties { /* [XID] */ /* 0x00000001898797A0-0x00000001898797C0 */ get => default; /* [XID] */ /* 0x0000000189880D50-0x0000000189880D70 */ set {} } // 0x000000018674DEC0-0x000000018674DF60 0x000000018674E640-0x000000018674E700
		public bool ExposePublicProperties { /* [XID] */ /* 0x000000018981D630-0x000000018981D650 */ get => default; /* [XID] */ /* 0x000000018982C4D0-0x000000018982C4F0 */ set {} } // 0x000000018674E000-0x000000018674E0A0 0x000000018674E7C0-0x000000018674E880
		public bool ArrayIndicesStartAtOne { /* [XID] */ /* 0x0000000189896C40-0x0000000189896C60 */ get => default; /* [XID] */ /* 0x000000018989E050-0x000000018989E070 */ set {} } // 0x000000018674DC40-0x000000018674DCE0 0x000000018674E350-0x000000018674E410
		public bool UseTitleCaseNaming { /* [XID] */ /* 0x00000001898A5AB0-0x00000001898A5AD0 */ get => default; /* [XID] */ /* 0x00000001898ACF60-0x00000001898ACF80 */ set {} } // 0x000000018674E2B0-0x000000018674E350 0x000000018674E940-0x000000018674EA00
		public int NestLimit { /* [XID] */ /* 0x00000001896872E0-0x0000000189687300 */ get => default; /* [XID] */ /* 0x00000001898BC290-0x00000001898BC2B0 */ set {} } // 0x000000018674E210-0x000000018674E2B0 0x000000018674E880-0x000000018674E940
		public RuntimeHierarchy ConnectedHierarchy { /* [XID] */ /* 0x0000000189A066E0-0x0000000189A06700 */ get => default; /* [XID] */ /* 0x00000001898CB010-0x00000001898CB030 */ set {} } // 0x000000018674DCE0-0x000000018674DD80 0x000000018674E410-0x000000018674E4C0
	
		// Nested types
		public delegate object InspectedObjectChangingDelegate(object previousInspectedObject, object newInspectedObject); // TypeDefIndex: 9973; 0x000000018673B2F0-0x000000018673B5A0
	
		// Constructors
		public RuntimeInspector() {} // 0x000000018674DAA0-0x000000018674DC40
		static RuntimeInspector() {} // 0x000000018674DA00-0x000000018674DAA0
	
		// Methods
		// [XID] // 0x00000001898D2770-0x00000001898D2790
		protected override void Awake() {} // 0x000000018674B960-0x000000018674BD10
		// [XID] // 0x00000001898D9FF0-0x00000001898DA010
		private void OnDestroy() {} // 0x000000018674CEA0-0x000000018674D040
		// [XID] // 0x0000000189B92600-0x0000000189B92620
		protected override void Update() {} // 0x000000018674D880-0x000000018674DA00
		// [XID] // 0x00000001898E9A50-0x00000001898E9A70
		public void Refresh() {} // 0x000000018674D470-0x000000018674D590
		// [XID] // 0x00000001898F0E60-0x00000001898F0E80
		protected override void RefreshSkin() {} // 0x000000018674D2D0-0x000000018674D470
		// [XID] // 0x00000001898A9DC0-0x00000001898A9DE0
		public void Inspect(object obj) {} // 0x000000018674C600-0x000000018674CBD0
		// [XID] // 0x0000000189900170-0x0000000189900190
		public void StopInspect() {} // 0x000000018674D590-0x000000018674D700
		// [XID] // 0x0000000189907760-0x0000000189907780
		public InspectorField CreateDrawerForType(System.Type type, Transform drawerParent, int depth, bool drawObjectsAsFields = true /* Metadata: 0x00AE6DE3 */) => default; // 0x000000018674BD10-0x000000018674BEA0
		// [XID] // 0x000000018990F0B0-0x000000018990F0D0
		private InspectorField InstantiateDrawer(InspectorField drawer, Transform drawerParent) => default; // 0x000000018674CBD0-0x000000018674CEA0
		// [XID] // 0x00000001898CF6C0-0x00000001898CF6E0
		private InspectorField GetDrawerForType(System.Type type, bool drawObjectsAsFields) => default; // 0x000000018674BEA0-0x000000018674C210
		// [XID] // 0x0000000189BBE8B0-0x0000000189BBE8D0
		public void PoolDrawer(InspectorField drawer) {} // 0x000000018674D040-0x000000018674D2D0
		// [XID] // 0x0000000189925AA0-0x0000000189925AC0
		public ExposedVariablesEnumerator GetExposedVariablesForType(System.Type type) => default; // 0x000000018674C210-0x000000018674C600
	}
}
