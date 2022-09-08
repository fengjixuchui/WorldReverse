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
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace RuntimeInspectorNamespace
{
	public class RuntimeHierarchy : SkinnedWindow // TypeDefIndex: 9959
	{
		// Fields
		private const string POOL_OBJECT_NAME = "RuntimeHierarchyPool"; // Metadata: 0x00AE6DC7
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float refreshInterval; // 0x28
		private float nextRefreshTime; // 0x2C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_objectNamesRefreshInterval; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private int poolCapacity; // 0x34
		private Transform poolParent; // 0x38
		private static int aliveHierarchies; // 0x00
		private static List<HierarchyItem> sceneDrawerPool; // 0x08
		private static List<HierarchyItem> transformDrawerPool; // 0x10
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_exposeUnityScenes; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_exposeDontDestroyOnLoadScene; // 0x41
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private string[] pseudoScenesOrder; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_createDraggedReferenceOnHold; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float m_draggedReferenceHoldTime; // 0x54
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool m_canReorganizeItems; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private float doubleClickThreshold; // 0x5C
		private float lastClickTime; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool syncSelectionWithEditorHierarchy; // 0x64
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RuntimeInspector m_connectedInspector; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ScrollRect scrollView; // 0x70
		private RectTransform drawArea; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image background; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image scrollbar; // 0x88
		private List<HierarchyItemRoot> sceneDrawers; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private HierarchyItemRoot sceneDrawerPrefab; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private HierarchyItemTransform transformDrawerPrefab; // 0xA0
		private HierarchyItem currentlySelectedDrawer; // 0xA8
		private Dictionary<string, HierarchyItemRoot> pseudoSceneDrawers; // 0xB0
		private Transform m_currentSelection; // 0xC8
	
		// Properties
		public float ObjectNamesRefreshInterval { /* [XID] */ /* 0x0000000189924470-0x0000000189924490 */ get => default; } // 0x0000000186807980-0x0000000186807A30 
		public bool ExposeUnityScenes { /* [XID] */ /* 0x000000018992B9A0-0x000000018992B9C0 */ get => default; /* [XID] */ /* 0x000000018976EE10-0x000000018976EE30 */ set {} } // 0x00000001868078E0-0x0000000186807980 0x0000000186808240-0x0000000186808350
		public bool ExposeDontDestroyOnLoadScene { /* [XID] */ /* 0x000000018993A9C0-0x000000018993A9E0 */ get => default; /* [XID] */ /* 0x0000000189BBAD80-0x0000000189BBADA0 */ set {} } // 0x0000000186807840-0x00000001868078E0 0x0000000186808160-0x0000000186808240
		public bool CreateDraggedReferenceOnHold { /* [XID] */ /* 0x000000018979B790-0x000000018979B7B0 */ get => default; /* [XID] */ /* 0x0000000189950E90-0x0000000189950EB0 */ set {} } // 0x0000000186807640-0x00000001868076E0 0x0000000186807E90-0x0000000186807F40
		public float DraggedReferenceHoldTime { /* [XID] */ /* 0x0000000189857480-0x00000001898574A0 */ get => default; /* [XID] */ /* 0x000000018985E6A0-0x000000018985E6C0 */ set {} } // 0x0000000186807790-0x0000000186807840 0x00000001868080B0-0x0000000186808160
		public bool CanReorganizeItems { /* [XID] */ /* 0x0000000189967590-0x00000001899675B0 */ get => default; /* [XID] */ /* 0x0000000189874A30-0x0000000189874A50 */ set {} } // 0x0000000186807500-0x00000001868075A0 0x0000000186807C70-0x0000000186807D20
		public RuntimeInspector ConnectedInspector { /* [XID] */ /* 0x00000001899763D0-0x00000001899763F0 */ get => default; /* [XID] */ /* 0x000000018987C640-0x000000018987C660 */ set {} } // 0x00000001868075A0-0x0000000186807640 0x0000000186807D20-0x0000000186807E90
		public Transform CurrentSelection { /* [XID] */ /* 0x00000001899A3C60-0x00000001899A3C80 */ get => default; /* [XID] */ /* 0x000000018981C640-0x000000018981C660 */ private set {} } // 0x00000001868076E0-0x0000000186807790 0x0000000186807F40-0x00000001868080B0
	
		// Events
		public event SelectionChangedDelegate OnSelectionChanged;
		public event DoubleClickDelegate OnItemDoubleClicked;
	
		// Nested types
		public delegate void SelectionChangedDelegate(Transform selection); // TypeDefIndex: 9960; 0x000000018674FBA0-0x000000018674FE00
	
		public delegate void DoubleClickDelegate(Transform selection); // TypeDefIndex: 9961; 0x0000000186739E10-0x000000018673A070
	
		// Constructors
		public RuntimeHierarchy() {} // 0x00000001868071B0-0x00000001868072C0
		static RuntimeHierarchy() {} // 0x0000000186807110-0x00000001868071B0
	
		// Methods
		// [XID] // 0x00000001899B30B0-0x00000001899B30D0
		protected override void Awake() {} // 0x0000000186803E60-0x00000001868040D0
		// [XID] // 0x0000000189AD3690-0x0000000189AD36B0
		private void Start() {} // 0x0000000186806CA0-0x0000000186806E40
		// [XID] // 0x0000000189ADB130-0x0000000189ADB150
		private void OnDestroy() {} // 0x00000001868054B0-0x00000001868056A0
		// [XID] // 0x00000001899C91E0-0x00000001899C9200
		protected override void Update() {} // 0x0000000186807040-0x0000000186807110
		// [XID] // 0x00000001899D0DB0-0x00000001899D0DD0
		public void Refresh() {} // 0x0000000186806410-0x0000000186806540
		// [XID] // 0x00000001899D80F0-0x00000001899D8110
		public void RefreshNameOf(Transform target) {} // 0x0000000186805F10-0x00000001868061E0
		// [XID] // 0x00000001899DF780-0x00000001899DF7A0
		protected override void RefreshSkin() {} // 0x00000001868061E0-0x0000000186806410
		// [XID] // 0x00000001897B2A90-0x00000001897B2AB0
		public void OnClicked(HierarchyItem drawer) {} // 0x0000000186805190-0x00000001868054B0
		// [XID] // 0x0000000189A0DBE0-0x0000000189A0DC00
		public bool Select(Transform selection) => default; // 0x0000000186806870-0x0000000186806CA0
		// [XID] // 0x0000000189A152E0-0x0000000189A15300
		public void Deselect() {} // 0x0000000186804920-0x00000001868049C0
		// [XID] // 0x00000001899FD690-0x00000001899FD6B0
		private void OnSceneLoaded(Scene arg0, LoadSceneMode arg1) {} // 0x00000001868056A0-0x0000000186805910
		// [XID] // 0x0000000189757C30-0x0000000189757C50
		private void OnSceneUnloaded(Scene arg0) {} // 0x0000000186805910-0x0000000186805BB0
		// [XID] // 0x00000001897935A0-0x00000001897935C0
		private Scene GetDontDestroyOnLoadScene() => default; // 0x00000001868049C0-0x0000000186804BA0
		// [IDTag] // 0x0000000189A13D30-0x0000000189A13D70
		// [XID] // 0x0000000189A13D30-0x0000000189A13D70
		public void AddToPseudoScene(string scene, Transform transform) {} // 0x0000000186803D70-0x0000000186803E60
		// [IDTag] // 0x0000000189A1DDE0-0x0000000189A1DE20
		// [XID] // 0x0000000189A1DDE0-0x0000000189A1DE20
		public void AddToPseudoScene(string scene, IEnumerable<Transform> transforms) {} // 0x0000000186803B60-0x0000000186803D70
		// [IDTag] // 0x0000000189A28220-0x0000000189A28260
		// [XID] // 0x0000000189A28220-0x0000000189A28260
		public void RemoveFromPseudoScene(string scene, Transform transform, bool deleteSceneIfEmpty) {} // 0x0000000186806540-0x0000000186806670
		// [IDTag] // 0x0000000189A32890-0x0000000189A328D0
		// [XID] // 0x0000000189A32890-0x0000000189A328D0
		public void RemoveFromPseudoScene(string scene, IEnumerable<Transform> transforms, bool deleteSceneIfEmpty) {} // 0x0000000186806670-0x0000000186806870
		// [XID] // 0x0000000189A3D0F0-0x0000000189A3D110
		private HierarchyRootPseudoScene GetPseudoScene(string scene, bool createIfNotExists) => default; // 0x0000000186804BA0-0x0000000186804D20
		// [XID] // 0x0000000189A449A0-0x0000000189A449C0
		public void CreatePseudoScene(string scene) {} // 0x0000000186804380-0x0000000186804460
		// [XID] // 0x000000018977D480-0x000000018977D4A0
		private HierarchyRootPseudoScene CreatePseudoSceneInternal(string scene) => default; // 0x00000001868040D0-0x0000000186804380
		// [XID] // 0x0000000189A537F0-0x0000000189A53810
		public void DeleteAllPseudoScenes() {} // 0x0000000186804460-0x0000000186804690
		// [XID] // 0x0000000189A5AF80-0x0000000189A5AFA0
		public void DeletePseudoScene(string scene) {} // 0x0000000186804690-0x0000000186804920
		// [XID] // 0x0000000189A62740-0x0000000189A62760
		private HierarchyItemRoot InstantiateSceneDrawer(IHierarchyRootContent target) => default; // 0x0000000186804F50-0x0000000186805080
		// [XID] // 0x0000000189A6A520-0x0000000189A6A540
		public HierarchyItemTransform InstantiateTransformDrawer(Transform drawerParent) => default; // 0x0000000186805080-0x0000000186805190
		// [XID] // 0x000000018979C550-0x000000018979C570
		private HierarchyItem InstantiateDrawer(List<HierarchyItem> drawerPool, HierarchyItem drawerPrefab, Transform drawerParent) => default; // 0x0000000186804D20-0x0000000186804F50
		// [XID] // 0x0000000189A793D0-0x0000000189A793F0
		public void PoolDrawer(HierarchyItem drawer) {} // 0x0000000186805BB0-0x0000000186805F10
	}
}
