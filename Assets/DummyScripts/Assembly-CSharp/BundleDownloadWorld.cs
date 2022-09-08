/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole;
using SimpleJSON;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public sealed class BundleDownloadWorld : BaseManager // TypeDefIndex: 11636
{
    // Fields
    public static JobType tryToDownloadJobType = (JobType)4; // 0x00
    private bool _enabled; // 0x10
    private Action _callBack; // 0x18
    private List<BundleDownloadBaseSystem> systems; // 0x20
    private JobType _jobType; // 0x28
    private JSONClass asbSetting; // 0x30
    private bool _checkDownloadData; // 0x38
    private bool _needDownloadRes; // 0x39
    private bool _needDownloadData; // 0x3A
    private bool _needDownloadSilence; // 0x3B
    private string _devBranch; // 0x40
    private uint _dataRevision; // 0x48
    private uint _silenceRevision; // 0x4C

    // Properties
    public static bool retryShowDownloadDialog { /* [XID] */ /* 0x000000018963EFF0-0x000000018963F030 */ get; /* [XID] */ /* 0x0000000189649980-0x00000001896499C0 */ set; } // 0x0000000181A6B8F0-0x0000000181A6B980 0x0000000181A683B0-0x0000000181A68440
    public bool checkDownloadData { /* [XID] */ /* 0x00000001898EDF50-0x00000001898EDF70 */ get => default; /* [XID] */ /* 0x00000001898F5810-0x00000001898F5830 */ set { } } // 0x0000000181A68440-0x0000000181A684E0 0x0000000181A68E90-0x0000000181A68F40
    public uint dataRevision { /* [XID] */ /* 0x0000000189662D10-0x0000000189662D30 */ get => default; /* [XID] */ /* 0x000000018966A8F0-0x000000018966A910 */ set { } } // 0x0000000181A687F0-0x0000000181A68890 0x0000000181A69BB0-0x0000000181A69D50
    public uint silenceRevision { /* [XID] */ /* 0x0000000189672550-0x0000000189672570 */ get => default; /* [XID] */ /* 0x0000000189679DC0-0x0000000189679DE0 */ set { } } // 0x0000000181A6A280-0x0000000181A6A320 0x0000000181A69B00-0x0000000181A69BB0

    // Constructors
    public BundleDownloadWorld() { } // 0x0000000181A6C2F0-0x0000000181A6C360
    static BundleDownloadWorld() { } // 0x0000000181A6C290-0x0000000181A6C2F0

    // Methods
    // [XID] // 0x00000001896814E0-0x0000000189681500
    public override void Init() { } // 0x0000000181A69EA0-0x0000000181A6A280
                                    // [XID] // 0x000000018992A240-0x000000018992A260
    public override void Destroy() { } // 0x0000000181A69500-0x0000000181A696A0
                                       // [XID] // 0x0000000189690AE0-0x0000000189690B00
    public static long GetDownloadSize() => default; // 0x0000000181A6BEC0-0x0000000181A6C0F0
                                                     // [XID] // 0x00000001896983A0-0x00000001896983C0
    public static bool CheckDownloadInterrupt() => default; // 0x0000000181A68B30-0x0000000181A68C40
                                                            // [XID] // 0x0000000189848BA0-0x0000000189848BC0
    public static void CheckOldPlayer(bool isProficientPlayer, Action callback) { } // 0x0000000181A6A860-0x0000000181A6AB90
                                                                                    // [XID] // 0x0000000189985330-0x0000000189985350
    internal void SetJobType(JobType type) { } // 0x0000000181A6B710-0x0000000181A6B7C0
                                               // [XID] // 0x000000018995FD50-0x000000018995FD70
    public void Start(Action callBack) { } // 0x0000000181A68F40-0x0000000181A691C0
                                           // [XID] // 0x00000001899229D0-0x00000001899229F0
    private void PrepareFakeGlobalVars() { } // 0x0000000181A6B150-0x0000000181A6B710
                                             // [XID] // 0x0000000189672780-0x00000001896727A0
    private void CheckDownloadTask(Action callBack) { } // 0x0000000181A697F0-0x0000000181A69900
                                                        // [XID] // 0x00000001896C3F40-0x00000001896C3F60
    private void CheckEngineRevision(Action callBack) { } // 0x0000000181A6B980-0x0000000181A6BEC0
                                                          // [XID] // 0x0000000189BAA360-0x0000000189BAA380
    private void CheckDownloadRes() { } // 0x0000000181A68890-0x0000000181A689D0
                                        // [XID] // 0x00000001896D2950-0x00000001896D2970
    private void CheckDownloadData() { } // 0x0000000181A6AB90-0x0000000181A6AD90
                                         // [XID] // 0x000000018996E8B0-0x000000018996E8D0
    private void AskCheckUpdate(Action callBack) { } // 0x0000000181A68630-0x0000000181A687F0
                                                     // [XID] // 0x0000000189A1B0E0-0x0000000189A1B100
    private string GetMediumDownloadMarkFilePath() => default; // 0x0000000181A69400-0x0000000181A69500
                                                               // [XID] // 0x00000001896E8FD0-0x00000001896E8FF0
    private string GetBaseRevisionFilePath() => default; // 0x0000000181A69900-0x0000000181A69A00
                                                         // [XID] // 0x00000001896F01B0-0x00000001896F01D0
    private void PrepareDownloadComponent(Action callBack) { } // 0x0000000181A6AD90-0x0000000181A6B150
                                                               // [XID] // 0x0000000189A04E40-0x0000000189A04E60
    private void LoadEmbededUI() { } // 0x0000000181A6B7C0-0x0000000181A6B8F0
                                     // [XID] // 0x00000001896FF550-0x00000001896FF570
    public override void Tick() { } // 0x0000000181A6C0F0-0x0000000181A6C290
                                    // [XID] // 0x0000000189706940-0x0000000189706960
    public void AllComplete(bool resUpdated, bool dataUpdated, bool silenceDataUpdated) { } // 0x0000000181A6A320-0x0000000181A6A860
                                                                                            // [XID] // 0x000000018970E1F0-0x000000018970E210
    public bool GetDownloadSystemIsPause() => default; // 0x0000000181A696A0-0x0000000181A697F0
                                                       // [XID] // 0x0000000189715650-0x0000000189715670
    public void SetDownloadSystemPause(bool pause) { } // 0x0000000181A689D0-0x0000000181A68B30
                                                       // [XID] // 0x0000000189A51FA0-0x0000000189A51FC0
    public void Pause() { } // 0x0000000181A69A60-0x0000000181A69B00
                            // [XID] // 0x000000018974A250-0x000000018974A270
    public void Cancel() { } // 0x0000000181A69260-0x0000000181A69400
                             // [XID] // 0x000000018972BC40-0x000000018972BC60
    public static void EnterBundleDownloadWorld(JobType jobType = JobType.MidPkgFull /* Metadata: 0x00AEA392 */) { } // 0x0000000181A68C40-0x0000000181A68E90
                                                                                                                     // [XID] // 0x00000001896F0400-0x00000001896F0420
    public long GetDownloadedResourceSize() => default; // 0x0000000181A684E0-0x0000000181A68630
                                                        // [XID] // 0x00000001896F7D90-0x00000001896F7DB0
    public long GetTotalResourceSize() => default; // 0x0000000181A69D50-0x0000000181A69EA0
}

