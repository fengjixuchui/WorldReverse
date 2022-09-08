/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text.RegularExpressions;
using IFix.Core;
using UnityEngine;
using UnityEngine.SceneManagement;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class GameObjectComponentToggler // TypeDefIndex: 27892
{
	// Fields
	private static Dictionary<string, IUnityObjectTogglerBase> _uoTogglerMap; // 0x00
	public const string UOT_GameObject = "GO"; // Metadata: 0x00B0D0DB
	public const string UOT_Behaviour = "BH"; // Metadata: 0x00B0D0E1
	public const string UOT_Animator = "AM"; // Metadata: 0x00B0D0E7
	public const string UOT_Renderer = "RD"; // Metadata: 0x00B0D0ED
	public const string UOT_ParticleSystemRenderer = "PSR"; // Metadata: 0x00B0D0F3
	public const string UOT_MeshRenderer = "MR"; // Metadata: 0x00B0D0FA
	public const string UOT_SkinnedMeshRenderer = "SMR"; // Metadata: 0x00B0D100
	public const string UOT_MiHoYoLoadLoader = "MLL"; // Metadata: 0x00B0D107
	public const string UOT_ParticleSystem = "PS"; // Metadata: 0x00B0D10E
	public const string UOT_RB = "RB"; // Metadata: 0x00B0D114

	// Nested types
	public interface IUnityObjectTogglerBase // TypeDefIndex: 27893
	{
		// Methods
		void ToggleUnityObjects(GameObject rootGameObject, bool isEnable, bool isLightweightStyle);
		void ToggleUnityObjectAttributesByValStr(GameObject rootGameObject, string componentItem, string value);
		void ToggleUnityObjectAttributesByValObject(GameObject rootGameObject, string componentItem, object value);
		void StatUnityObjects(IEnumerable<GameObject> gos, bool openExplorer, bool upload);
	}

	public abstract class UnityObjectToggler<T> : IUnityObjectTogglerBase // TypeDefIndex: 27894
		where T : UnityEngine.Object
	{
		// Constructors
		protected UnityObjectToggler() {}

		// Methods
		public abstract T[] FindAllTargets(GameObject rootGameObject);
		public abstract void ToggleSingleUnityObject(T uobj, bool isEnable, bool isLightweightStyle);
		public void ToggleUnityObjects(GameObject rootGameObject, bool isEnable, bool isLightweightStyle) {}
		public bool ToggleSingleUnityObjectAttributeByValStr(T uobj, string componentItemID, string value) => default;
		public void ToggleUnityObjectAttributesByValStr(GameObject rootGameObject, string componentItemID, string value) {}
		public virtual bool ToggleSingleUnityObjectAttributeByValObject(T uobj, string componentItemID, object value) => default;
		public void ToggleUnityObjectAttributesByValObject(GameObject rootGameObject, string componentItemID, object value) {}
		public void StatUnityObjects(IEnumerable<GameObject> gos, bool openExplorer, bool upload) {}
	}

	public class GameObjectToggler : UnityObjectToggler<GameObject> // TypeDefIndex: 27895
	{
		// Constructors
		public GameObjectToggler() {} // 0x0000000186585A30-0x0000000186585AA0

		// Methods
		// [XID] // 0x000000018982E9A0-0x000000018982E9C0
		public override GameObject[] FindAllTargets(GameObject rootGameObject) => default; // 0x0000000186585910-0x0000000186585A30
		// [XID] // 0x0000000189836300-0x0000000189836320
		public override void ToggleSingleUnityObject(GameObject uobj, bool isEnable, bool isLightweightStyle) {} // 0x0000000186585690-0x00000001865857C0
		// [XID] // 0x000000018983D750-0x000000018983D770
		public override bool ToggleSingleUnityObjectAttributeByValObject(GameObject uobj, string componentItemID, object value) => default; // 0x00000001865857C0-0x0000000186585910
	}

	public class BehaviourToggler : UnityObjectToggler<Behaviour> // TypeDefIndex: 27896
	{
		// Constructors
		public BehaviourToggler() {} // 0x0000000186585440-0x00000001865854B0

		// Methods
		// [XID] // 0x0000000189844FF0-0x0000000189845010
		public override Behaviour[] FindAllTargets(GameObject rootGameObject) => default; // 0x0000000186585370-0x0000000186585440
		// [XID] // 0x000000018984C4A0-0x000000018984C4C0
		public override void ToggleSingleUnityObject(Behaviour uobj, bool isEnable, bool isLightweightStyle) {} // 0x0000000186585280-0x0000000186585370
	}

	public class AnimatorToggler : UnityObjectToggler<Animator> // TypeDefIndex: 27897
	{
		// Constructors
		public AnimatorToggler() {} // 0x0000000186585E40-0x0000000186585EB0

		// Methods
		// [XID] // 0x0000000189853570-0x0000000189853590
		public override Animator[] FindAllTargets(GameObject rootGameObject) => default; // 0x0000000186585D70-0x0000000186585E40
		// [XID] // 0x000000018985AFE0-0x000000018985B000
		public override void ToggleSingleUnityObject(Animator uobj, bool isEnable, bool isLightweightStyle) {} // 0x0000000186585AA0-0x0000000186585B90
		// [XID] // 0x00000001898624C0-0x00000001898624E0
		public override bool ToggleSingleUnityObjectAttributeByValObject(Animator uobj, string componentItemID, object value) => default; // 0x0000000186585B90-0x0000000186585D70
	}

	public class RendererToggler : UnityObjectToggler<Renderer> // TypeDefIndex: 27898
	{
		// Constructors
		public RendererToggler() {} // 0x0000000186585210-0x0000000186585280

		// Methods
		// [XID] // 0x0000000189869930-0x0000000189869950
		public static void ToggleRendererEnable(Renderer uobj, bool isEnable, bool isLightweightStyle) {} // 0x0000000186585060-0x0000000186585140
		// [XID] // 0x0000000189870B50-0x0000000189870B70
		public static bool ToggleRendererAttribute(Renderer uobj, string componentItemID, object value) => default; // 0x0000000186584CD0-0x0000000186584F70
		// [XID] // 0x0000000189878680-0x00000001898786A0
		public override Renderer[] FindAllTargets(GameObject rootGameObject) => default; // 0x0000000186585140-0x0000000186585210
		// [XID] // 0x000000018987FB50-0x000000018987FB70
		public override void ToggleSingleUnityObject(Renderer uobj, bool isEnable, bool isLightweightStyle) {} // 0x0000000186584F70-0x0000000186585060
	}

	public class SkinnedMeshRendererToggler : UnityObjectToggler<SkinnedMeshRenderer> // TypeDefIndex: 27899
	{
		// Constructors
		public SkinnedMeshRendererToggler() {} // 0x0000000186584C60-0x0000000186584CD0

		// Methods
		// [XID] // 0x00000001898871A0-0x00000001898871C0
		public override SkinnedMeshRenderer[] FindAllTargets(GameObject rootGameObject) => default; // 0x0000000186584B90-0x0000000186584C60
		// [XID] // 0x000000018988E330-0x000000018988E350
		public override void ToggleSingleUnityObject(SkinnedMeshRenderer uobj, bool isEnable, bool isLightweightStyle) {} // 0x00000001865849B0-0x0000000186584AA0
		// [XID] // 0x00000001898959C0-0x00000001898959E0
		public override bool ToggleSingleUnityObjectAttributeByValObject(SkinnedMeshRenderer uobj, string componentItemID, object value) => default; // 0x0000000186584AA0-0x0000000186584B90
	}

	public class ParticleSystemToggler : UnityObjectToggler<ParticleSystem> // TypeDefIndex: 27900
	{
		// Constructors
		public ParticleSystemToggler() {} // 0x0000000186586DF0-0x0000000186586ED0

		// Methods
		// [XID] // 0x00000001898A4900-0x00000001898A4920
		public override ParticleSystem[] FindAllTargets(GameObject rootGameObject) => default; // 0x0000000186586D20-0x0000000186586DF0
		// [XID] // 0x00000001898ABE00-0x00000001898ABE20
		public override void ToggleSingleUnityObject(ParticleSystem uobj, bool isEnable, bool isLightweightStyle) {} // 0x00000001865864F0-0x0000000186586600
		// [XID] // 0x00000001898B3570-0x00000001898B3590
		public override bool ToggleSingleUnityObjectAttributeByValObject(ParticleSystem uobj, string componentItemID, object value) => default; // 0x0000000186586600-0x0000000186586D20
	}

	public class ParticleSystemRendererToggler : UnityObjectToggler<ParticleSystemRenderer> // TypeDefIndex: 27901
	{
		// Constructors
		public ParticleSystemRendererToggler() {} // 0x0000000186586480-0x00000001865864F0

		// Methods
		// [XID] // 0x00000001898BB300-0x00000001898BB320
		public override ParticleSystemRenderer[] FindAllTargets(GameObject rootGameObject) => default; // 0x00000001865863B0-0x0000000186586480
		// [XID] // 0x00000001898C25E0-0x00000001898C2600
		public override void ToggleSingleUnityObject(ParticleSystemRenderer uobj, bool isEnable, bool isLightweightStyle) {} // 0x00000001865861D0-0x00000001865862C0
		// [XID] // 0x00000001898CA040-0x00000001898CA060
		public override bool ToggleSingleUnityObjectAttributeByValObject(ParticleSystemRenderer uobj, string componentItemID, object value) => default; // 0x00000001865862C0-0x00000001865863B0
	}

	public class MeshRendererToggler : UnityObjectToggler<MeshRenderer> // TypeDefIndex: 27902
	{
		// Constructors
		public MeshRendererToggler() {} // 0x0000000186586160-0x00000001865861D0

		// Methods
		// [XID] // 0x00000001898D17A0-0x00000001898D17C0
		public override MeshRenderer[] FindAllTargets(GameObject rootGameObject) => default; // 0x0000000186586090-0x0000000186586160
		// [XID] // 0x00000001898D8EB0-0x00000001898D8ED0
		public override void ToggleSingleUnityObject(MeshRenderer uobj, bool isEnable, bool isLightweightStyle) {} // 0x0000000186585EB0-0x0000000186585FA0
		// [XID] // 0x00000001898E0BC0-0x00000001898E0BE0
		public override bool ToggleSingleUnityObjectAttributeByValObject(MeshRenderer uobj, string componentItemID, object value) => default; // 0x0000000186585FA0-0x0000000186586090
	}

	public class MiHoYoLoadLoaderToggler : UnityObjectToggler<MiHoYoLodLoader> // TypeDefIndex: 27903
	{
		// Constructors
		public MiHoYoLoadLoaderToggler() {} // 0x0000000186565CF0-0x0000000186565EA0

		// Methods
		// [XID] // 0x00000001898E86F0-0x00000001898E8710
		public static void DebugPrint(MiHoYoLodLoader uobj, int targetLOD, int realTargetLOD) {} // 0x0000000186565610-0x00000001865659C0
		// [XID] // 0x00000001898EFE70-0x00000001898EFE90
		public override MiHoYoLodLoader[] FindAllTargets(GameObject rootGameObject) => default; // 0x0000000186565C20-0x0000000186565CF0
		// [XID] // 0x00000001898F7710-0x00000001898F7730
		public override void ToggleSingleUnityObject(MiHoYoLodLoader uobj, bool isEnable, bool isLightweightStyle) {} // 0x0000000186565520-0x0000000186565610
		// [XID] // 0x00000001898FEE20-0x00000001898FEE40
		public override bool ToggleSingleUnityObjectAttributeByValObject(MiHoYoLodLoader uobj, string componentItemID, object value) => default; // 0x00000001865659C0-0x0000000186565C20
	}

	public class RigidbodyToggler : UnityObjectToggler<Rigidbody> // TypeDefIndex: 27904
	{
		// Constructors
		public RigidbodyToggler() {} // 0x0000000186584940-0x00000001865849B0

		// Methods
		// [XID] // 0x0000000189906620-0x0000000189906640
		public override Rigidbody[] FindAllTargets(GameObject rootGameObject) => default; // 0x0000000186584870-0x0000000186584940
		// [XID] // 0x000000018990E000-0x000000018990E020
		public override void ToggleSingleUnityObject(Rigidbody uobj, bool isEnable, bool isLightweightStyle) {} // 0x0000000186584590-0x00000001865846A0
		// [XID] // 0x0000000189915730-0x0000000189915750
		public override bool ToggleSingleUnityObjectAttributeByValObject(Rigidbody uobj, string componentItemID, object value) => default; // 0x00000001865846A0-0x0000000186584870
	}

	// Constructors
	static GameObjectComponentToggler() {} // 0x0000000186569AE0-0x000000018656A010

	// Methods
	// [XID] // 0x0000000189749160-0x0000000189749180
	public static object CreateCommandObjectFromString(string inStr, string objectType) => default; // 0x0000000186565FC0-0x0000000186566100
	// [XID] // 0x0000000189750690-0x00000001897506B0
	public static bool IsUnityGameObjectSelfEnabled(GameObject go) => default; // 0x0000000186567100-0x00000001865671D0
	// [XID] // 0x0000000189757B10-0x0000000189757B30
	public static bool IsUnityGameObjectEnabled(GameObject go) => default; // 0x0000000186566100-0x0000000186566290
	// [XID] // 0x000000018975F5D0-0x000000018975F5F0
	public static bool IsUnityObjectEnabled(UnityEngine.Object inUO) => default; // 0x0000000186568810-0x0000000186568A80
	// [XID] // 0x0000000189766A60-0x0000000189766A80
	public static bool IsUnityObjectSelfEnabled(UnityEngine.Object inUO) => default; // 0x0000000186566F20-0x0000000186567100
	// [XID] // 0x000000018976E030-0x000000018976E050
	public static int GetWorkLoad(UnityEngine.Object inUO) => default; // 0x0000000186565EA0-0x0000000186565FC0
	// [XID] // 0x0000000189775770-0x0000000189775790
	public static string GetGameObjectRemark(UnityEngine.Object inUO) => default; // 0x00000001865676F0-0x00000001865678F0
	// [XID] // 0x000000018977D070-0x000000018977D090
	public static string GetRemark(UnityEngine.Object inUO) => default; // 0x0000000186566910-0x0000000186566DD0
	// [XID] // 0x0000000189784AA0-0x0000000189784AC0
	public static float GetToCameraDistance(UnityEngine.Object inUO) => default; // 0x0000000186567B90-0x0000000186567E10
	// [XID] // 0x000000018978BFE0-0x000000018978C000
	public static IEnumerable<GameObject> FindGameObjectsByPath(string path) => default; // 0x00000001865686C0-0x0000000186568810
	// [XID] // 0x0000000189793450-0x0000000189793470
	public static IEnumerable<GameObject> FindGameObjectsByEntityID(uint runtimeID) => default; // 0x00000001865696D0-0x0000000186569970
	// [XID] // 0x000000018979B720-0x000000018979B740
	public static IEnumerable<GameObject> FindGameObjectsByConfigID(uint configID) => default; // 0x00000001865678F0-0x0000000186567B90
	// [IDTag] // 0x00000001897A2B00-0x00000001897A2B40
	// [XID] // 0x00000001897A2B00-0x00000001897A2B40
	public static void ToggleUnityComponent(IEnumerable<GameObject> gos, string id, bool isEnable, bool isLightweightStyle) {} // 0x0000000186568C60-0x0000000186568F30
	// [IDTag] // 0x00000001897AD360-0x00000001897AD3A0
	// [XID] // 0x00000001897AD360-0x00000001897AD3A0
	public static void ToggleUnityComponentAttributes(IEnumerable<GameObject> gos, string id, string attributeID, string value) {} // 0x0000000186568F30-0x0000000186569210
	// [XID] // 0x00000001897B8140-0x00000001897B8160
	public static List<Scene> GetAllSceneIncludeDontDestroy() => default; // 0x0000000186568550-0x00000001865686C0
	// [XID] // 0x00000001897C01D0-0x00000001897C01F0
	public static GameObject FindGameObject(string path) => default; // 0x0000000186566290-0x0000000186566710
	// [XID] // 0x00000001897C7A00-0x00000001897C7A20
	public static void FindGameObjectsByRegexRecursively(GameObject rootGO, Regex inRegex, List<GameObject> matchedGOs, bool needChildren) {} // 0x0000000186566710-0x0000000186566910
	// [XID] // 0x00000001897CED40-0x00000001897CED60
	public static void ToggleGameObjectByRegex(bool isOn, string toggleItemName, string rootHierarchyPath, string regexRule, Action<GameObject, bool> onActive = null) {} // 0x00000001865671D0-0x0000000186567520
	// [XID] // 0x00000001897D6440-0x00000001897D6460
	public static void HandleGameObjectByRootGameObjectRecursively(GameObject rootGO, Action<GameObject> onHandleGameObject) {} // 0x0000000186568390-0x0000000186568550
	// [XID] // 0x00000001897DDC40-0x00000001897DDC60
	public static void HandleGameObjectByRootHierarchyPath(string rootGOPath, Action<GameObject> onHandleGameObject) {} // 0x0000000186567F90-0x0000000186568070
	// [IDTag] // 0x00000001897E5630-0x00000001897E5670
	// [XID] // 0x00000001897E5630-0x00000001897E5670
	public static void ToggleUnityComponent(string rootGOPath, string id, bool isEnable, bool isLightweightStyle) {} // 0x0000000186568A80-0x0000000186568C60
	// [IDTag] // 0x00000001897F00B0-0x00000001897F00F0
	// [XID] // 0x00000001897F00B0-0x00000001897F00F0
	public static void ToggleUnityComponentAttributes(string rootGOPath, string id, string attributeID, string value) {} // 0x0000000186569210-0x00000001865693F0
	// [XID] // 0x00000001897FABD0-0x00000001897FABF0
	public static void ToggleUnityComponentAttributesByValObject(IEnumerable<GameObject> gos, string id, string attributeID, object value) {} // 0x00000001865693F0-0x00000001865696D0
	// [XID] // 0x00000001898021A0-0x00000001898021C0
	public static void StatUnityComponent(IEnumerable<GameObject> gos, string id, bool openExplorer, bool upload) {} // 0x0000000186566DD0-0x0000000186566F20
	// [XID] // 0x0000000189809630-0x0000000189809650
	public static void StatUnityComponentByRootPath(string rootGOPath, string id, bool openExplorer, bool upload) {} // 0x0000000186568070-0x00000001865681D0
	// [XID] // 0x0000000189810E40-0x0000000189810E60
	public static void ParseToggleComponentFromCMDLine(string[] args, IEnumerable<GameObject> gos, int startIndex) {} // 0x0000000186567520-0x00000001865676F0
	// [XID] // 0x00000001898188F0-0x0000000189818910
	public static void ParseToggleComponentAttributeFromCMDLine(string[] args, IEnumerable<GameObject> gos, int startIndex) {} // 0x0000000186567E10-0x0000000186567F90
	// [XID] // 0x00000001898201A0-0x00000001898201C0
	public static void ParseToggleComponentAttributeFromCMDLineByValObject(string[] args, IEnumerable<GameObject> gos, int startIndex, object objValue) {} // 0x0000000186569970-0x0000000186569AE0
	// [XID] // 0x0000000189827720-0x0000000189827740
	public static void ParseStatComponent(string[] args, IEnumerable<GameObject> gos, int startIndex) {} // 0x00000001865681D0-0x0000000186568390
}

