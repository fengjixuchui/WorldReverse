/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using MoleMole.Config;
using SimpleJSON;
using UnityEngine;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class GadgetData // TypeDefIndex: 19496
{
	// Fields
	private static Dictionary<string, ConfigGadget> _gadgetConfigs; // 0x00
	private static Dictionary<string, GadgetConfigPage> _gadgetConfigPages; // 0x08
	private static Dictionary<string, ulong> _gadgetConfigPathMap; // 0x10
	private const string CONFIG_GADGET_NPC = "StandOnly"; // Metadata: 0x00AFC928
	private static Dictionary<ulong, GadgetPreloadData> _gadgetPreloadData; // 0x18

	// Nested types
	private class GadgetPreloadData : AssetLoadBase2<GameObject> // TypeDefIndex: 19497
	{
		// Fields
		private Dictionary<BaseEntity, int> _refEntities; // 0x48

		// Constructors
		public GadgetPreloadData() {} // 0x000000018298C5F0-0x000000018298C690

		// Methods
		// [XID] // 0x0000000189606DE0-0x0000000189606E00
		public override void Clear() {} // 0x000000018298B240-0x000000018298B300
		// [XID] // 0x0000000189B55B40-0x0000000189B55B60
		public void Preload(BaseEntity entity) {} // 0x000000018298B170-0x000000018298B240
		// [XID] // 0x000000018960DEB0-0x000000018960DED0
		public AsyncJob DoPreloadAsyncWithJob(Action onLoadFinish, BaseEntity entity) => default; // 0x000000018298AF80-0x000000018298B0A0
		// [XID] // 0x000000018961D670-0x000000018961D690
		public bool ReleasePreload(BaseEntity entity) => default; // 0x000000018298B0A0-0x000000018298B170
		// [XID] // 0x0000000189624AF0-0x0000000189624B10
		public void AddRefCount(BaseEntity entity) {} // 0x000000018298BAA0-0x000000018298BEF0
		// [XID] // 0x0000000189B141D0-0x0000000189B141F0
		public void MinusRefCount(BaseEntity entity) {} // 0x000000018298BEF0-0x000000018298C590
		// [XID] // 0x0000000189633DD0-0x0000000189633DF0
		public string Dump() => default; // 0x000000018298B300-0x000000018298BAA0
	}

	public struct GadgetConfigOnWaitData // TypeDefIndex: 19498
	{
		// Fields
		public string jsonName; // 0x00
		public BaseEntity queryEntity; // 0x08

		// Constructors
		public GadgetConfigOnWaitData(string name, BaseEntity entity) {
			jsonName = default;
			queryEntity = default;
		} // 0x000000018296D730-0x000000018296D7D0
	}

	public struct GadgetConfigOnLoadingData // TypeDefIndex: 19499
	{
		// Fields
		public GadgetConfigPage gadgetInitLoading; // 0x00
		public List<GadgetConfigOnWaitData> gadgetOnWait; // 0x08

		// Constructors
		public GadgetConfigOnLoadingData(GadgetConfigPage gadgetInitLoading) {
			this.gadgetInitLoading = default;
			gadgetOnWait = default;
		} // 0x000000018296D700-0x000000018296D730
	}

	public class GadgetConfigPage : EntityConfigPageBase // TypeDefIndex: 19500
	{
		// Fields
		private static SerializeBinHandler _serializeBin; // 0x00
		private static SerializeJsonHandler _serializeJson; // 0x08
		private Action<object, ulong> _onSerializedAsync; // 0x58

		// Constructors
		public GadgetConfigPage() {} // 0x000000018296C4D0-0x000000018296C580
		static GadgetConfigPage() {} // 0x000000018296C3A0-0x000000018296C4D0

		// Methods
		// [XID] // 0x000000018964A500-0x000000018964A520
		public override AsyncJob PreloadAsyncWithJob(BaseEntity entity, Action onLoadFinish) => default; // 0x000000018296C240-0x000000018296C3A0
		// [XID] // 0x0000000189651C60-0x0000000189651C80
		protected static ConfigMetaConfig.PathHash[] GetGadgetRegistryPathes() => default; // 0x000000018296BBF0-0x000000018296BCD0
		// [XID] // 0x00000001896594B0-0x00000001896594D0
		public ConfigGadget GetGadgetConfig() => default; // 0x000000018296B5D0-0x000000018296B7C0
		// [XID] // 0x0000000189660B30-0x0000000189660B50
		protected override void LoadEntityConfig(ulong configHash) {} // 0x000000018296BCD0-0x000000018296BD80
		// [XID] // 0x0000000189668520-0x0000000189668540
		private void LoadGadgetConfig(ulong configHash) {} // 0x000000018296B950-0x000000018296BBF0
		// [XID] // 0x000000018966FFD0-0x000000018966FFF0
		private static object SerializeBin(ByteArray byteArr, int threadFlag = 0 /* Metadata: 0x00AFC935 */) => default; // 0x000000018296BF40-0x000000018296C240
		// [XID] // 0x0000000189677910-0x0000000189677930
		private static object SerializeJson(JSONNode node) => default; // 0x000000018296B7C0-0x000000018296B950
		// [XID] // 0x000000018967EDC0-0x000000018967EDE0
		private static void OnSerialized(object obj, ulong path, bool async = false /* Metadata: 0x00AFC939 */) {} // 0x000000018296BD80-0x000000018296BF40
		// [XID] // 0x0000000189686710-0x0000000189686730
		private void OnSerializedAsync(object obj, ulong path) {} // 0x000000018296B4D0-0x000000018296B5D0
	}

	// Constructors
	static GadgetData() {} // 0x000000018298AA00-0x000000018298AB20

	// Methods
	// [XID] // 0x0000000189B7CF00-0x0000000189B7CF20
	public static void ReloadFromFile() {} // 0x0000000182989560-0x0000000182989630
	// [XID] // 0x0000000189B84DD0-0x0000000189B84DF0
	public static void CheckClear() {} // 0x0000000182986C90-0x00000001829874E0
	[DebuggerHidden] // 0x0000000189B8BC00-0x0000000189B8BC40
	// [XID] // 0x0000000189B8BC00-0x0000000189B8BC40
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC924 */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x000000018298A050-0x000000018298A190
	// [XID] // 0x0000000189B96100-0x0000000189B96120
	public static void LoadGadgetConfig() {} // 0x0000000182988F20-0x0000000182989210
	// [XID] // 0x0000000189B9D680-0x0000000189B9D6A0
	public static void PreloadEntityGadgets(BaseEntity entity, string[] gadgetIDs) {} // 0x0000000182989630-0x0000000182989980
	// [XID] // 0x0000000189AA64E0-0x0000000189AA6500
	public static void PreloadEntityGadgetsAsyncWithJob(BaseEntity entity, string[] gadgetIDs, Action<string> preloadedCallback = null, List<AsyncJob> jobs = null) {} // 0x0000000182988500-0x0000000182988AB0
	// [XID] // 0x0000000189BAC1F0-0x0000000189BAC210
	public static void ReleasePreloadedEntityGadgets(BaseEntity entity, string[] gadgetIDs) {} // 0x00000001829874E0-0x0000000182987940
	[Preserve] // 0x0000000189BB3A10-0x0000000189BB3A50
	// [XID] // 0x0000000189BB3A10-0x0000000189BB3A50
	public static string Dump() => default; // 0x0000000182989B40-0x000000018298A050
	// [XID] // 0x0000000189BBDE90-0x0000000189BBDEB0
	public static void BuildRuntimeGadgetPathMap() {} // 0x0000000182987C60-0x0000000182988320
	// [XID] // 0x0000000189BC5B80-0x0000000189BC5BA0
	public static void ClearConfigPagesOnExit() {} // 0x0000000182989980-0x0000000182989B40
	// [XID] // 0x0000000189BCD5C0-0x0000000189BCD5E0
	public static bool HasGadgetConfig(string jsonName) => default; // 0x0000000182988320-0x0000000182988410
	// [XID] // 0x00000001897DBE20-0x00000001897DBE40
	public static ConfigGadget GetGadgetConfig(string jsonName) => default; // 0x0000000182987940-0x0000000182987C60
	// [XID] // 0x0000000189BDC5A0-0x0000000189BDC5C0
	public static void PreloadGadgetConfig(BaseEntity entity, string jsonName) {} // 0x0000000182988AB0-0x0000000182988F20
	// [XID] // 0x00000001895E8F30-0x00000001895E8F50
	public static AsyncJob PreloadGadgetConfigAsyncWithJob(BaseEntity entity, string jsonName, Action preloadedCallback) => default; // 0x000000018298A190-0x000000018298A6A0
	// [XID] // 0x00000001895F0720-0x00000001895F0740
	public static void ReleasePreloadGadgetConfig(BaseEntity entity, string jsonName) {} // 0x0000000182989210-0x0000000182989560
	// [XID] // 0x00000001895F8130-0x00000001895F8150
	public static void MergeLoadedPages(Dictionary<string, ConfigGadget> loadedGadgetConfigs, ulong sourceHash) {} // 0x000000018298A6A0-0x000000018298AA00
	// [XID] // 0x00000001895FF690-0x00000001895FF6B0
	public static ulong GetJsonConfigPathHash(string jsonName) => default; // 0x0000000182988410-0x0000000182988500
}

