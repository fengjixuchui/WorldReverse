/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using FullInspector;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class ViewCache // TypeDefIndex: 28716
{
	// Fields
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private SimpleLRU<ViewCacheEntry> _lruCache; // 0x10
	[ShowInInspector] // 0x0000000189698D50-0x0000000189698D60
	private List<ViewCacheEntry> _alwaysCache; // 0x18
	private Transform _dontDestroyViewRoot; // 0x20
	public static string DONT_DESTROY_VIEW_ROOT_NAME; // 0x00
	private List<string> _alreadyDontDestroyOnLoadList; // 0x28
	private Dictionary<string, GameObject> _prefabObjectCache; // 0x30
	private Dictionary<string, uint> _prefabHandleCache; // 0x38
	private Dictionary<string, int> _prefabCounts; // 0x40

	// Constructors
	public ViewCache() {} // Dummy constructor
	public ViewCache(int lruCapacity) {} // 0x0000000181943860-0x00000001819439B0
	static ViewCache() {} // 0x00000001819437F0-0x0000000181943860

	// Methods
	// [XID] // 0x0000000189640F60-0x0000000189640F80
	public void LoadInstancedView(ContextPattern config, Action<GameObject> onLoadResult, bool enableView = true /* Metadata: 0x00B0E5B9 */, bool anyncLoad = true /* Metadata: 0x00B0E5BA */) {} // 0x0000000181942270-0x0000000181942870
	// [XID] // 0x0000000189648850-0x0000000189648870
	public void ReleaseInstancedView(GameObject view, ContextPattern config) {} // 0x0000000181940E90-0x00000001819414E0
	// [XID] // 0x000000018980F070-0x000000018980F090
	private void DestoryViewObject(GameObject view, string viewPrefabPath) {} // 0x00000001819419F0-0x0000000181941C50
	// [XID] // 0x0000000189657820-0x0000000189657840
	public void ClearLRUCache() {} // 0x00000001819414E0-0x00000001819419F0
	// [XID] // 0x000000018965EE80-0x000000018965EEA0
	public void ClearAlwaysCache() {} // 0x0000000181942CC0-0x00000001819431A0
	// [XID] // 0x00000001896665C0-0x00000001896665E0
	public void ForceClear() {} // 0x0000000181943540-0x00000001819437F0
	// [XID] // 0x000000018966DDC0-0x000000018966DDE0
	public void Reset(bool markAlreadyDontDestroyOnLoad) {} // 0x0000000181941D50-0x0000000181942170
	// [IDTag] // 0x0000000189675BC0-0x0000000189675C00
	// [XID] // 0x0000000189675BC0-0x0000000189675C00
	private bool IsDontDestroyOnLoad(ViewCacheEntry view) => default; // 0x0000000181940C90-0x0000000181940D90
	// [IDTag] // 0x0000000189680550-0x0000000189680590
	// [XID] // 0x0000000189680550-0x0000000189680590
	private bool IsDontDestroyOnLoad(ContextPattern config) => default; // 0x0000000181940D90-0x0000000181940E90
	// [XID] // 0x000000018968AE40-0x000000018968AE60
	private void DoDontDestroyOnLoad(ViewCacheEntry view) {} // 0x0000000181941C50-0x0000000181941D50
	// [XID] // 0x0000000189692B10-0x0000000189692B30
	private void MarkAlreadyDontDestroyOnLoad(ViewCacheEntry view) {} // 0x0000000181942170-0x0000000181942270
	// [XID] // 0x0000000189699E20-0x0000000189699E40
	private void InistantiateView(ContextPattern config, GameObject go, Action<GameObject> onLoadResult) {} // 0x00000001819431A0-0x0000000181943320
	// [XID] // 0x0000000189A10C70-0x0000000189A10C90
	private void LoadAndInstantiateView(ContextPattern config, Action<GameObject> onLoadResult, bool anyncLoad) {} // 0x0000000181942870-0x0000000181942CC0
	// [XID] // 0x00000001896A8A40-0x00000001896A8A60
	private Transform GetDontDestroyViewRoot() => default; // 0x0000000181943320-0x0000000181943540
}

