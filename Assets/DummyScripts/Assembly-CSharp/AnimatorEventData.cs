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
using UniRx;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public static class AnimatorEventData // TypeDefIndex: 19263
{
	// Fields
	private static Dictionary<int, AnimatorEventPattern> _animatorEventPatternDict; // 0x00
	private static List<uint> _handles; // 0x08
	private static List<ConfigAnimatorEventRefPage> _dropUnfinishedLoadingPage; // 0x10
	private static Dictionary<int, ulong> _animPatternHash2ConfigHashMap; // 0x18
	private static Dictionary<ulong, ConfigAnimatorEventRefPage> _configPatternHash2RefPageMap; // 0x20
	private const int ANIM_PATTERN_LRU_CACHE_SIZE = 10; // Metadata: 0x00AFC672
	private static DoublyList<ConfigAnimatorEventRefPage> _releasedPageLRUCacheList; // 0x28
	private static Dictionary<ulong, DoublyList<ConfigAnimatorEventRefPage>> _releasePageLRUNodeMap; // 0x30
	private static HashSet<int> _animPatternHashSet; // 0x38

	// Properties
	private static string ANIM_PATTERN_TO_CONFIG_PATH { /* [XID] */ /* 0x00000001897E2A20-0x00000001897E2A40 */ get; } // 0x0000000182FEA0B0-0x0000000182FEA150 

	// Nested types
	public class ConfigAnimatorEventRefPage : AssetLoadBase2<ConfigAnimatorEventPattern> // TypeDefIndex: 19264
	{
		// Fields
		protected int[] _animPatterns; // 0x48
		protected List<Tuple<int, Status>> _pageStatusHistory; // 0x50
		protected Status _loadStatus; // 0x58

		// Properties
		public Status loadStatus { /* [XID] */ /* 0x000000018985F4B0-0x000000018985F4D0 */ get => default; /* [XID] */ /* 0x0000000189866CD0-0x0000000189866CF0 */ set {} } // 0x0000000182FF3800-0x0000000182FF38A0 0x0000000182FF38A0-0x0000000182FF3960
		public ulong configHash { /* [XID] */ /* 0x000000018989A950-0x000000018989A970 */ get => default; } // 0x0000000182FF3960-0x0000000182FF3A00 

		// Nested types
		public enum Status // TypeDefIndex: 19265
		{
			Init = 0,
			Recycled = 1,
			Loading = 2,
			BlockLoadedOnAsyncLoad = 3,
			Loaded = 4,
			Destroy = 5
		}

		// Constructors
		public ConfigAnimatorEventRefPage() {} // Dummy constructor
		public ConfigAnimatorEventRefPage(ulong hash) {} // 0x0000000182FF49E0-0x0000000182FF4AB0

		// Methods
		// [XID] // 0x000000018986E550-0x000000018986E570
		public override AsyncJob DoPreloadAsyncWithJob(Action onLoadFinish) => default; // 0x0000000182FF31B0-0x0000000182FF33A0
		// [XID] // 0x0000000189A28390-0x0000000189A283B0
		protected void MarkPageStateChange() {} // 0x0000000182FF47C0-0x0000000182FF48D0
		// [XID] // 0x000000018987D540-0x000000018987D560
		public bool IsPageRefEmpty() => default; // 0x0000000182FF3A00-0x0000000182FF3AB0
		// [XID] // 0x0000000189884450-0x0000000189884470
		public override void MinusRefCount() {} // 0x0000000182FF3AB0-0x0000000182FF3BC0
		// [XID] // 0x000000018988BB60-0x000000018988BB80
		protected override void BroadcastFinishCallback() {} // 0x0000000182FF48D0-0x0000000182FF49E0
		// [XID] // 0x0000000189893250-0x0000000189893270
		public override void BeforeFinish() {} // 0x0000000182FF4040-0x0000000182FF4100
		// [XID] // 0x00000001898A1C00-0x00000001898A1C20
		private void LoadPatternToGlobalDict() {} // 0x0000000182FF4100-0x0000000182FF4670
		// [XID] // 0x00000001898A9450-0x00000001898A9470
		public void RecycleToLRU() {} // 0x0000000182FF4670-0x0000000182FF47C0
		// [XID] // 0x00000001898B0C80-0x00000001898B0CA0
		public override void Clear() {} // 0x0000000182FF34F0-0x0000000182FF37A0
		// [XID] // 0x0000000189763610-0x0000000189763630
		public string GetLogString() => default; // 0x0000000182FF3C20-0x0000000182FF4040
	}

	// Constructors
	static AnimatorEventData() {} // 0x0000000182FED550-0x0000000182FED730

	// Methods
	// [XID] // 0x0000000189794FE0-0x0000000189795000
	public static void Clear() {} // 0x0000000182FEA2E0-0x0000000182FEA560
	// [XID] // 0x000000018979D410-0x000000018979D430
	public static void ReloadFromFile() {} // 0x0000000182FEA560-0x0000000182FEAF90
	[DebuggerHidden] // 0x00000001897A46D0-0x00000001897A4710
	// [XID] // 0x00000001897A46D0-0x00000001897A4710
	public static IEnumerator ReloadFromFileAsync(float progressSpan = 0f /* Metadata: 0x00AFC66E */, Action<float> moveOneStepCallback = null, Action<string> finishCallback = null) => default; // 0x0000000182FEC150-0x0000000182FEC290
	// [XID] // 0x00000001897AF130-0x00000001897AF150
	public static ConfigAnimatorEventPattern[] GetConfigsForEditor() => default; // 0x0000000182FE8950-0x0000000182FE8B80
	// [IDTag] // 0x00000001897B6DB0-0x00000001897B6DF0
	// [XID] // 0x00000001897B6DB0-0x00000001897B6DF0
	public static AnimatorEventPattern GetAnimatorEventPattern(string patternName) => default; // 0x0000000182FE91D0-0x0000000182FE92A0
	// [IDTag] // 0x00000001897C1970-0x00000001897C19B0
	// [XID] // 0x00000001897C1970-0x00000001897C19B0
	public static AnimatorEventPattern GetAnimatorEventPattern(int patternNameHash) => default; // 0x0000000182FE92A0-0x0000000182FE95B0
	// [XID] // 0x00000001897CBED0-0x00000001897CBEF0
	public static Dictionary<int, AnimatorEventPattern> GetAllAnimatorEventPatterns() => default; // 0x0000000182FEC080-0x0000000182FEC150
	// [XID] // 0x00000001897D38C0-0x00000001897D38E0
	public static void DropUnfinishedLoads() {} // 0x0000000182FEC290-0x0000000182FEC6B0
	// [XID] // 0x000000018975BBF0-0x000000018975BC10
	public static string CheckAsyncLoadingPage(HashSet<string> patterns) => default; // 0x0000000182FED100-0x0000000182FED550
	// [XID] // 0x00000001897EA1C0-0x00000001897EA1E0
	private static void IterateAllEntityAnimPattern(BaseEntity entity, Action<BaseEntity, string, Action<string>, Action<string>> handleAction, Action<string> preloadCallback = null, Action<string> preloadedCallback = null) {} // 0x0000000182FE9980-0x0000000182FEA0B0
	// [XID] // 0x00000001897F1E50-0x00000001897F1E70
	private static void IterateAllEntityAnimPatternWithJob(BaseEntity entity, Func<BaseEntity, string, Action<string>, Action<string>, AsyncJob> handleAction, Action<AsyncJob> jobAction, Action<string> preloadCallback = null, Action<string> preloadedCallback = null) {} // 0x0000000182FEB8F0-0x0000000182FEC080
	// [IDTag] // 0x00000001897F9700-0x00000001897F9740
	// [XID] // 0x00000001897F9700-0x00000001897F9740
	public static void PreloadAnimatorPattern(BaseEntity entity) {} // 0x0000000182FEB3D0-0x0000000182FEB570
	// [IDTag] // 0x0000000189803D30-0x0000000189803D70
	// [XID] // 0x0000000189803D30-0x0000000189803D70
	public static void ReleaseAnimatorPattern(BaseEntity entity) {} // 0x0000000182FEC6B0-0x0000000182FEC850
	// [IDTag] // 0x000000018980E290-0x000000018980E2D0
	// [XID] // 0x000000018980E290-0x000000018980E2D0
	public static void PreloadAnimatorPattern(BaseEntity entity, string animPattern, Action<string> preloadCallback = null, Action<string> preloadedCallback = null) {} // 0x0000000182FEB130-0x0000000182FEB3D0
	// [IDTag] // 0x0000000189818C30-0x0000000189818C70
	// [XID] // 0x0000000189818C30-0x0000000189818C70
	private static void PreloadAnimatorPattern(BaseEntity entity, int patternHash, Action<string> preloadCallback = null, Action<string> preloadedCallback = null) {} // 0x0000000182FEB570-0x0000000182FEB8F0
	// [IDTag] // 0x0000000189822F70-0x0000000189822FB0
	// [XID] // 0x0000000189822F70-0x0000000189822FB0
	public static void PreloadAnimatorPatternAsyncWithJob(BaseEntity entity, Action<string> preloadCallback, Action<string> preloadedCallback, Action<AsyncJob> jobAction) {} // 0x0000000182FE8B80-0x0000000182FE8D60
	// [IDTag] // 0x000000018982D600-0x000000018982D640
	// [XID] // 0x000000018982D600-0x000000018982D640
	public static AsyncJob PreloadAnimatorPatternAsyncWithJob(BaseEntity entity, string animPattern, Action<string> preloadCallback, Action<string> preloadedCallback) => default; // 0x0000000182FE8D60-0x0000000182FE91D0
	// [IDTag] // 0x0000000189837C80-0x0000000189837CC0
	// [XID] // 0x0000000189837C80-0x0000000189837CC0
	public static void ReleaseAnimatorPattern(BaseEntity entity, string animPattern, Action<string> preloadCallback = null, Action<string> preloadedCallback = null) {} // 0x0000000182FEC850-0x0000000182FECCA0
	// [XID] // 0x0000000189842380-0x00000001898423A0
	private static void ReuseConfigPageFromLRU(ulong configHash) {} // 0x0000000182FEA150-0x0000000182FEA2E0
	// [XID] // 0x00000001898497D0-0x00000001898497F0
	private static void PushConfigPageLRU(ulong configHash, ConfigAnimatorEventRefPage refPage) {} // 0x0000000182FE95B0-0x0000000182FE9980
	// [XID] // 0x0000000189850FB0-0x0000000189850FD0
	private static void RemoveConfigPageFromLRU(ulong configHash, ConfigAnimatorEventRefPage refPage) {} // 0x0000000182FEAF90-0x0000000182FEB130
	// [XID] // 0x0000000189858400-0x0000000189858420
	private static void ClearAnimEventPatternCache() {} // 0x0000000182FECCA0-0x0000000182FED100
}

