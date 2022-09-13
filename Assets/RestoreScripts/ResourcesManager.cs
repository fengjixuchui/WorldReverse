/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using IFix.Core;
using MoleMole;
using UnityEngine;
using UnityEngine.Scripting;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class ResourcesManager : GlobalManager // TypeDefIndex: 21274
{
    // Fields
    private const float QUIET_DOWN_TIME_OUT = 10f; // Metadata: 0x00AFF3EA
    private readonly List<uint> _svcHandles = new List<uint>(); // 0x10
    private QuietDownCallback _quietDownCallback; // 0x18
    private bool _asset_updated; // 0x20
    private float _quietDownTimeOutDue; // 0x24
    public static Action<List<string>> dumpAllLoadedAsset; // 0x00
    private static LRUList<loadJob> _assetLoadList = new LRUList<loadJob>(10000); // 0x08
    private static LRUList<loadJob> _instantiateList = new LRUList<loadJob>(10000); // 0x10
    private static LRUList<loadJob> _bundleLoadList = new LRUList<loadJob>(10000); // 0x18

    // Properties
    public bool ForceLoadIndex { /* [XID] */ /* 0x0000000189902090-0x00000001899020D0 */ get; /* [XID] */ /* 0x000000018990C9F0-0x000000018990CA30 */ private set; } // 0x0000000181F17420-0x0000000181F17480 0x0000000181F16320-0x0000000181F16380
    public bool downloadSucc { /* [XID] */ /* 0x00000001899174A0-0x00000001899174E0 */ get; /* [XID] */ /* 0x0000000189921CA0-0x0000000189921CE0 */ set; } // 0x0000000181F16E90-0x0000000181F16EF0 0x0000000181F14340-0x0000000181F143A0
    public bool assetUpdated { /* [XID] */ /* 0x000000018992C140-0x000000018992C160 */ get => _asset_updated; } // 0x0000000181F134C0-0x0000000181F13560 
    public List<string> allLoadedAsset { /* [XID] */ /* 0x00000001899335A0-0x00000001899335C0 */ get => MoleMole.Lazy<ExternalResources>.Get<ExternalResources>().allLoadedAsset; } // 0x0000000181F17950-0x0000000181F17A10 
    public int streamingResourceRevision { get; /* [XID] */ /* 0x0000000189942380-0x00000001899423C0 */ private set; } // 0x0000000181F137D0-0x0000000181F13830 0x0000000181F170B0-0x0000000181F17110
    public int externalResourceRevision { get; /* [XID] */ /* 0x0000000189954330-0x0000000189954370 */ private set; } // 0x0000000181F16E30-0x0000000181F16E90 0x0000000181F131E0-0x0000000181F13240

    // Nested types
    private struct loadJob // TypeDefIndex: 21275
    {
        // Fields
        public string name; // 0x00
        public float time; // 0x08
    }

    private class LRUList<T> : ICollection<T>, ICollection // TypeDefIndex: 21276
    {
        // Fields
        private int _index;
        private readonly List<T> _list;
        private int _capacity;

        // Properties
        public int Count { get => default; }
        public bool IsReadOnly { get => default; }
        public object SyncRoot { get => default; }
        public bool IsSynchronized { get => default; }

        // Constructors
        public LRUList() { } // Dummy constructor
        public LRUList(int count) { }

        // Methods
        public void Clear() { }
        public void Add(T item) { }
        public bool Contains(T item) => default;
        public void CopyTo(T[] array, int arrayIndex) { }
        public bool Remove(T item) => default;
        public IEnumerator<T> GetEnumerator() => default;
        IEnumerator IEnumerable.GetEnumerator() => default;
        public void CopyTo(Array array, int index) { }
        public void Sort(Comparison<T> a) { }
    }

    public delegate void QuietDownCallback(); // TypeDefIndex: 21277; 0x0000000181F1FAB0-0x0000000181F1FC10

    // Methods
    // [XID] // 0x000000018995ED90-0x000000018995EDB0
    public override void ReloadRes()
    {
        _svcHandles.Clear();
        WarmupShaders();
    } // 0x0000000181F17FA0-0x0000000181F18060
      // [XID] // 0x00000001899665F0-0x0000000189966610
    public void AndroidWarmUp() { /* 无关 */} // 0x0000000181F149B0-0x0000000181F14F80
                                            // [XID] // 0x000000018996D9D0-0x000000018996D9F0
    public static void Refresh()
    {
        _instantiateList.Clear();
        _bundleLoadList.Clear();
        _assetLoadList.Clear();
    } // 0x0000000181F12F40-0x0000000181F13070
      // [XID] // 0x0000000189975570-0x0000000189975590
    private static void OnPrefabLoadFinish(string path, float time)
    {
        if (!ExternalResourceProvider.unlimited)
        {
            loadJob job = new();
            job.name = path;
            job.time = time;
            _instantiateList.Add(job);
        }
    } // 0x0000000181F13350-0x0000000181F134C0
      // [XID] // 0x000000018997C710-0x000000018997C730
    private static void onAssetLoadFinish(string path, float time)
    {
        if (!ExternalResourceProvider.unlimited)
        {
            loadJob job = new();
            job.name = path;
            job.time = time;
            _assetLoadList.Add(job);
        }
    } // 0x0000000181F143A0-0x0000000181F14510
      // [XID] // 0x0000000189984450-0x0000000189984470
    private static void onBundleLoadFinish(string path, float time)
    {
        if (!ExternalResourceProvider.unlimited)
        {
            loadJob job = new();
            job.name = path;
            job.time = time;
            _bundleLoadList.Add(job);
        }
    } // 0x0000000181F13070-0x0000000181F131E0
      // [XID] // 0x000000018998BEF0-0x000000018998BF10
    private static int Sort(loadJob a, loadJob b) => Mathf.CeilToInt((b.time - a.time) * 100f); // 0x0000000181F17A10-0x0000000181F17B30
                                                                                                // [IDTag] // 0x0000000189993BB0-0x0000000189993BF0
                                                                                                // [XID] // 0x0000000189993BB0-0x0000000189993BF0
    public static void Dump() { } // 0x0000000181F15220-0x0000000181F16320
                                  // [XID] // 0x000000018999E610-0x000000018999E630
    public override void Init()
    {
        PrefabLoadJob.onLoadFinish = OnPrefabLoadFinish;
        AssetLoadJob.onLoadFinish = onAssetLoadFinish;
        SeperateBundleLoadJob.onLoadFinish = onBundleLoadFinish;
        MarkSilenceUpdateBlock();
        StartReportFileWrite();
        // 自定义引擎代码
        //UnityEngine.ObjectInstanceCache.defaultDeactiveAfterAsyncInstantiate = GlobalVars.defaultDeactiveAfterInstantiate;
        _asset_updated = false;
        AssetBundleSettings.Load();
        MoleMole.Lazy<ExternalResources>.Get<ExternalResources>().Init();
        string indexPath = Path.Combine(ResourceConstants.externalBlockDirectory, "00/31049740.blk");
        if (File.Exists(indexPath))
        {
            LoadExternalIndex();
            ReadInExternalResourceRevision();
        }
        else
        {
            LoadStreamingIndex(false);
            ReadInStreamingResourceRevision();
        }
    } // 0x0000000181F16380-0x0000000181F16810
      // [XID] // 0x00000001899A6010-0x00000001899A6030
    public override void Destroy()
    {
        UnloadShaders();
        MoleMole.Lazy<ExternalResources>.Get<ExternalResources>().Destroy();
    } // 0x0000000181F13CF0-0x0000000181F13DC0
      // [XID] // 0x00000001899AD620-0x00000001899AD640
    public override void ClearOnLevelDestroy() { } // 0x0000000181F13640-0x0000000181F136E0
                                                   // [XID] // 0x00000001899B4E80-0x00000001899B4EA0
    public override void Tick()
    {

        ExternalResources externalResources = MoleMole.Lazy<ExternalResources>.Get<ExternalResources>();
        externalResources.Tick();
        if (_quietDownCallback != null)
        {
            if (_quietDownTimeOutDue > 0.0f && Time.realtimeSinceStartup >= _quietDownTimeOutDue)
            {
                SuperDebug.LogWarning(externalResources.activeJobAndJobQueueInfo);
                SuperDebug.LogWarning("Quiet down callback time out.");
                StringBuilder smjb = new StringBuilder();
                if (externalResources.undergoingUnloadedAssetJobNames != null)
                {
                    foreach (string text in externalResources.undergoingUnloadedAssetJobNames)
                    {
                        smjb.Append("	" + text);
                    }
                    SuperDebug.LogWarning("undergoingUnloadedAssetJobNames:" + smjb);
                }
                smjb.Length = 0;
                if (externalResources.undergoingAssetJobNames != null)
                {

                    foreach (string text in externalResources.undergoingAssetJobNames)
                    {
                        smjb.Append("	" + text);
                    }
                    SuperDebug.LogWarning("undergoingUnloadedAssetJobNames:" + smjb);
                }
                smjb.Length = 0;
                if (externalResources.undergoingBundleJobNames != null)
                {

                    foreach (string text in externalResources.undergoingBundleJobNames)
                    {
                        smjb.Append("	" + text);
                    }
                    SuperDebug.LogWarning("undergoingUnloadedAssetJobNames:" + smjb);
                }
                _quietDownTimeOutDue += 10.0f;
            }
            if (externalResources.idle)
            {
                if (dumpAllLoadedAsset != null)
                {
                    dumpAllLoadedAsset(externalResources.allLoadedAsset);
                }
            }
            _quietDownCallback();
            _quietDownCallback = null;
            _quietDownTimeOutDue = 0f;
        }
    } // 0x0000000181F18060-0x0000000181F18710
      // [XID] // 0x00000001899BC5F0-0x00000001899BC610
    public override void LateTick()
    {
        MoleMole.Lazy<ExternalResources>.Get<ExternalResources>().LateTick();
    } // 0x0000000181F17110-0x0000000181F171D0
      // [XID] // 0x00000001899C3F40-0x00000001899C3F60
    public bool StartFromBundleDownload() => AssetBundleSettings.enableDownload; // 0x0000000181F13EC0-0x0000000181F13F70
                                                                                 // [XID] // 0x000000018982B7E0-0x000000018982B800
    public void LoadStreamingIndex(bool onlyStreaming = false /* Metadata: 0x00AFF3E9 */)
    {
        ForceLoadIndex = onlyStreaming;
        string indexPath = Path.Combine(ResourceConstants.externalBlockDirectory, "00/31049740.blk");
        MoleMole.Lazy<ExternalResources>.Get<ExternalResources>().LoadResourceIndex(indexPath, onlyStreaming);
    } // 0x0000000181F150D0-0x0000000181F15220
      // [XID] // 0x00000001899D2B90-0x00000001899D2BB0
    public void RefreshBlockFile()
    {
        MoleMole.Lazy<ExternalResources>.Get<ExternalResources>().RefreshBlockFile();
    } // 0x0000000181F17CE0-0x0000000181F17DA0
      // [XID] // 0x00000001899DA1E0-0x00000001899DA200
    public void MarkAssetUpdated()
    {
        // 自定义引擎代码
        //Application.BeginRuntimeFileUpdate();
        _asset_updated = true;
        downloadSucc = false;
    } // 0x0000000181F13560-0x0000000181F13640
    [DebuggerHidden] // 0x00000001899E1CB0-0x00000001899E1D00
                     // [IDTag] // 0x00000001899E1CB0-0x00000001899E1D00
                     // [XID] // 0x00000001899E1CB0-0x00000001899E1D00
    public IEnumerator PreToLoadSceneIter(Func<IEnumerator> callback)
    {
        if (assetUpdated)
        {
            Singleton<UIManager>.Instance.MaskPage(true);
            yield return null;
        }
        AssetClear();
        GlobalDataManager.RefreshData();
        yield return callback();
    }
    // 0x0000000181F16A80-0x0000000181F16BA0
    [DebuggerHidden] // 0x00000001899EEFF0-0x00000001899EF040
                     // [IDTag] // 0x00000001899EEFF0-0x00000001899EF040
                     // [XID] // 0x00000001899EEFF0-0x00000001899EF040
    public IEnumerator PreToLoadSceneIter(Action callback)
    {
        if (assetUpdated)
        {
            Singleton<UIManager>.Instance.MaskPage(true);
            yield return null;
        }
        else
        {
            callback();
            yield break;
        }
        AssetClear();
        if (downloadSucc)
        {
            GlobalDataManager.RefreshData();
        }
        yield return null;
        callback();
    } // 0x0000000181F16960-0x0000000181F16A80
      // [IDTag] // 0x00000001899FC960-0x00000001899FC9B0
    [Preserve] // 0x00000001899FC960-0x00000001899FC9B0
               // [XID] // 0x00000001899FC960-0x00000001899FC9B0
    public override string Dump(string tag) => default; // 0x0000000181F13DC0-0x0000000181F13EC0
                                                        // [XID] // 0x0000000189A09DC0-0x0000000189A09DE0
    public void AssetClear()
    {
        MoleMole.Lazy<ExternalResources>.Get<ExternalResources>().UnloadBundle();
        CommonMiscs.ClearObject();
        IconUtils.UnloadAllSpriteAtlas();
        //自定义引擎代码
        //Application.EndRuntimeFileUpdate();
        ManagerController.ReloadGlobalManagers();
        if (downloadSucc)
        {
            SchedulerConfigUtils.LoadScheduleConfig();
        }
        _asset_updated = false;
    } // 0x0000000181F16EF0-0x0000000181F170B0
    [DebuggerHidden] // 0x0000000189A11640-0x0000000189A11680
                     // [XID] // 0x0000000189A11640-0x0000000189A11680
    public IEnumerator BlockWarmUp(Action<float> progressCB = null) => MoleMole.Lazy<ExternalResources>.Get<ExternalResources>().BlockWarmUp(progressCB); // 0x0000000181F13240-0x0000000181F13350
                                                                                                                                                          // [XID] // 0x0000000189A1B790-0x0000000189A1B7B0
    public bool LoadExternalIndex()
    {
        string indexPath = Path.Combine(ResourceConstants.externalBlockDirectory, "00/31049740.blk");
        if (File.Exists(indexPath))
        {
            LoadStreamingIndex();
            return true;
        }
        if (MoleMole.Lazy<ExternalResources>.Get<ExternalResources>().LoadResourceIndex(indexPath, false))
            return true;
        UnityEngine.Debug.LogError("External Asset Index Load Error,Read Streaming Instead");
        SuperDebug.VeryImportantError("External Asset Index Load Error,Read Streaming Instead", ErrorLevel.High, ErrorCategory.Resource);
        PersistDirUtil.ClearStateFilesInPersistDir();
        LoadStreamingIndex(true);
        return false;
    }// 0x0000000181F171D0-0x0000000181F17420
     // [XID] // 0x0000000189A231A0-0x0000000189A231C0
    public void ReadInStreamingResourceRevision()
    {
        streamingResourceRevision = ReadInRevision(ResourceConstants.streamingAssetRevisionFile);
    } // 0x0000000181F14130-0x0000000181F14220
      // [XID] // 0x0000000189A2A360-0x0000000189A2A380
    public void ReadInExternalResourceRevision()
    {
        externalResourceRevision = ReadInRevision(ResourceConstants.externalAssetRevisionFile);
    } // 0x0000000181F146F0-0x0000000181F147E0
      // [XID] // 0x0000000189A317D0-0x0000000189A317F0
    public void WarmupShaders()
    {
        if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.OSXEditor)
            return;
        string svcCatalogFile;
        if (AssetBundleSettings.enableDownload)
        {
            svcCatalogFile = ResourceConstants.svcCatalogFile;
        }
        else
        {
            svcCatalogFile = ResourceConstants.streamingSvcCatalogFile;
        }
        if (!FileUtility.IsFileExists(svcCatalogFile))
        {
            if (!AssetBundleSettings.enableDownload)
            {
                SuperDebug.LogError("Can not found svc catalog file " + svcCatalogFile);
                return;
            }
        }

        if (!FileUtility.IsFileExists(ResourceConstants.streamingSvcCatalogFile))
        {
            if (!AssetBundleSettings.enableDownload)
            {
                SuperDebug.LogError("Can not found svcCatalogFile " + ResourceConstants.svcCatalogFile + " and streamingSvcCatalogFile {1}" + ResourceConstants.streamingSvcCatalogFile);
                return;
            }
        }
        MoleMole.Lazy<ExternalResources>.Get<ExternalResources>().ShaderBlockWarmUp();
        var text = File.OpenText(ResourceConstants.streamingSvcCatalogFile);
        while (text.EndOfStream)
        {
            WarmupShaderVariantCollection(text.ReadLine());
        }
        text.Dispose();
    } // 0x0000000181F17480-0x0000000181F17810
      // [XID] // 0x0000000189A39330-0x0000000189A39350
    public void UnloadShaders()
    {
        foreach (var handle in _svcHandles)
        {
            MoleMole.Lazy<ExternalResources>.Get<ExternalResources>().DismissResource(handle, true);
        }
        _svcHandles.Clear();
    } // 0x0000000181F17810-0x0000000181F17950
      // [XID] // 0x0000000189A40AD0-0x0000000189A40AF0
    public void DropUnstartedLoads()
    {
        MoleMole.Lazy<ExternalResources>.Get<ExternalResources>().DropUnstartedLoads();
    } // 0x0000000181F14280-0x0000000181F14340
      // [XID] // 0x0000000189A48170-0x0000000189A48190
    public void RegisterQuietDownCallback(QuietDownCallback callback)
    {
        _quietDownCallback = callback;
        _quietDownTimeOutDue = Time.realtimeSinceStartup + 10f;
        MoleMole.Lazy<ExternalResources>.Get<ExternalResources>().SwitchUnlimitedMode(true);
    } // 0x0000000181F136E0-0x0000000181F137D0
      // [XID] // 0x0000000189A4FA40-0x0000000189A4FA60
    public ExternalResources GetExternalResources() => MoleMole.Lazy<ExternalResources>.Get<ExternalResources>(); // 0x0000000181F17C30-0x0000000181F17CE0
                                                                                                                  // [XID] // 0x0000000189689160-0x0000000189689180
    private int ReadInRevision(string filePath)  // 0x0000000181F17DA0-0x0000000181F17FA0
    {
        int revision = 0;
        if (File.Exists(filePath))
        {
            var text = File.OpenText(filePath);
            if (!text.EndOfStream)
            {
                int.TryParse(text.ReadLine(), out revision);
            }
            text.Dispose();
        }
        return revision;
    }
    // [XID] // 0x0000000189A5EBF0-0x0000000189A5EC10
    private void WarmupShaderVariantCollection(string line)
    {
        ExtractShaderVariantCollectionInfo(line, out var path, out var isExternal);
        if (!string.IsNullOrEmpty(path))
        {
            if (isExternal)
                WarmupExternalShaderVariantCollection(path);
            else
                WarmupInternalShaderVariantCollection(path);
        }
    } // 0x0000000181F14F80-0x0000000181F150D0
      // [XID] // 0x0000000189A662F0-0x0000000189A66310
    private void WarmupInternalShaderVariantCollection(string path)
    {
        if (!string.IsNullOrEmpty(path))
        {
            if (path.EndsWith("@warmup"))
            {
                var shaderVariantCollection = Resources.Load<ShaderVariantCollection>(path);
                if (shaderVariantCollection)
                {
                    shaderVariantCollection.WarmUp();
                }
            }
        }
    } // 0x0000000181F14510-0x0000000181F14670
      // [XID] // 0x0000000189A6DA40-0x0000000189A6DA60
    private void WarmupExternalShaderVariantCollection(string path) { } // 0x0000000181F13830-0x0000000181F13C90
                                                                        // [XID] // 0x0000000189A75190-0x0000000189A751B0
    private void ExtractShaderVariantCollectionInfo(string line, out string path, out bool isExternal)
    {
        path = default;
        isExternal = default;
    } // 0x0000000181F16810-0x0000000181F16960
      // [XID] // 0x0000000189A7CDF0-0x0000000189A7CE10
    public static void UnloadBlock(int languageCode, int id) { } // 0x0000000181F16BA0-0x0000000181F16E30
                                                                 // [XID] // 0x0000000189A846C0-0x0000000189A846E0
    public static void MarkSilenceUpdateBlock() { } // 0x0000000181F17B30-0x0000000181F17C30
                                                    // [XID] // 0x0000000189BC05C0-0x0000000189BC05E0
    public static void UnloadSilenceUpdateBlock() { } // 0x0000000181F14010-0x0000000181F14130
                                                      // [XID] // 0x0000000189AF0AB0-0x0000000189AF0AD0
    public static void StartReportFileWrite() { } // 0x0000000181F147E0-0x0000000181F149B0
                                                  // [XID] // 0x0000000189A9AFC0-0x0000000189A9AFE0
    public static void StopReportFileWrite() { } // 0x0000000181F13F70-0x0000000181F14010
}

