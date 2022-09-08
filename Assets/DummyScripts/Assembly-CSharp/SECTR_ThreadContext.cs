/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using miHoYoThread;
using MoleMole;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class SECTR_ThreadContext // TypeDefIndex: 20311
{
	// Fields
	private SECTR_JobList<SECTRJob> _sectrIJobRequests; // 0x10
	private SECTER_ContextGenerator _generator; // 0x18
	private int _groupIndex; // 0x20
	private ContextType _state; // 0x24
	private ITaskData _taskData; // 0x28
	protected List<int> _cachePosIDs; // 0x30
	protected List<Vector3> _cachePosVecs; // 0x38
	private List<string> _logCache; // 0x40

	// Nested types
	public class SECTR_DelayActionContext : SECTRJob, IAutoAllocRecycle // TypeDefIndex: 20312
	{
		// Fields
		public ISECTR_ThreadCB lodThread; // 0x10
		public ulong curTime; // 0x18
		public ulong delayTime; // 0x20

		// Constructors
		public SECTR_DelayActionContext() {} // 0x000000018489F250-0x000000018489F2F0

		// Methods
		[BlackList] // 0x00000001896EDFD0-0x00000001896EE010
		// [XID] // 0x00000001896EDFD0-0x00000001896EE010
		public override void AutoAllocTypeFields() {} // 0x000000018489ECE0-0x000000018489ED80
		[BlackList] // 0x00000001896F8540-0x00000001896F8580
		// [XID] // 0x00000001896F8540-0x00000001896F8580
		public override void AutoRecycleTypeFields() {} // 0x000000018489ED80-0x000000018489EE30
		[BlackList] // 0x0000000189702ED0-0x0000000189702F10
		// [XID] // 0x0000000189702ED0-0x0000000189702F10
		public override void ReturnToObjectPool() {} // 0x000000018489F1B0-0x000000018489F250
		// [XID] // 0x000000018970D650-0x000000018970D670
		public override SECTRJobType GetJobType() => default; // 0x000000018489F000-0x000000018489F0A0
		// [XID] // 0x0000000189714A50-0x0000000189714A70
		public void Init(ISECTR_ThreadCB lod, float delay, ulong cur) {} // 0x000000018489EE90-0x000000018489EFA0
		// [XID] // 0x000000018971C4A0-0x000000018971C4C0
		public override void Release() {} // 0x000000018489F0A0-0x000000018489F150
		// [XID] // 0x00000001897238D0-0x00000001897238F0
		public override bool Execute() => default; // 0x000000018489EBF0-0x000000018489ECE0
	}

	public class SECTR_LoadByteArrayContext : SECTRJob, IAutoAllocRecycle // TypeDefIndex: 20313
	{
		// Fields
		public SECTR_GUID secGuid; // 0x10
		public SECTR_Manager.LoadByteArrayCallBack loadedCB; // 0x18
		public AssetJobPriority priority; // 0x20
		public uint uid; // 0x24

		// Constructors
		public SECTR_LoadByteArrayContext() {} // 0x00000001848C2710-0x00000001848C27B0

		// Methods
		[BlackList] // 0x000000018972B050-0x000000018972B090
		// [XID] // 0x000000018972B050-0x000000018972B090
		public override void AutoAllocTypeFields() {} // 0x00000001848C21C0-0x00000001848C2260
		[BlackList] // 0x00000001897356F0-0x0000000189735730
		// [XID] // 0x00000001897356F0-0x0000000189735730
		public override void AutoRecycleTypeFields() {} // 0x00000001848C2260-0x00000001848C2310
		[BlackList] // 0x00000001897405B0-0x00000001897405F0
		// [XID] // 0x00000001897405B0-0x00000001897405F0
		public override void ReturnToObjectPool() {} // 0x00000001848C2670-0x00000001848C2710
		// [XID] // 0x000000018974ADE0-0x000000018974AE00
		public override SECTRJobType GetJobType() => default; // 0x00000001848C24C0-0x00000001848C2560
		// [XID] // 0x0000000189751E70-0x0000000189751E90
		public void Init(SECTR_GUID inSecGuid, AssetJobPriority p, SECTR_Manager.LoadByteArrayCallBack inCB) {} // 0x00000001848C2370-0x00000001848C2460
		// [XID] // 0x0000000189759540-0x0000000189759560
		public override void Release() {} // 0x00000001848C2560-0x00000001848C2610
		// [XID] // 0x0000000189761110-0x0000000189761130
		public override bool Execute() => default; // 0x00000001848C20C0-0x00000001848C21C0
	}

	public class SECTR_LoadObjContext : SECTRJob, IAutoAllocRecycle // TypeDefIndex: 20314
	{
		// Fields
		public SECTR_GUID secGuid; // 0x10
		public Transform transform; // 0x18
		public SECTR_Manager.LoadGameObjectCallBack loadedCB; // 0x20
		public AssetJobPriority priority; // 0x28
		public uint uid; // 0x2C

		// Constructors
		public SECTR_LoadObjContext() {} // 0x00000001848C2E40-0x00000001848C2EE0

		// Methods
		[BlackList] // 0x0000000189768480-0x00000001897684C0
		// [XID] // 0x0000000189768480-0x00000001897684C0
		public override void AutoAllocTypeFields() {} // 0x00000001848C28C0-0x00000001848C2960
		[BlackList] // 0x0000000189772B20-0x0000000189772B60
		// [XID] // 0x0000000189772B20-0x0000000189772B60
		public override void AutoRecycleTypeFields() {} // 0x00000001848C2960-0x00000001848C2A20
		[BlackList] // 0x000000018977D2C0-0x000000018977D300
		// [XID] // 0x000000018977D2C0-0x000000018977D300
		public override void ReturnToObjectPool() {} // 0x00000001848C2DA0-0x00000001848C2E40
		// [XID] // 0x0000000189787AA0-0x0000000189787AC0
		public override SECTRJobType GetJobType() => default; // 0x00000001848C2BF0-0x00000001848C2C90
		// [XID] // 0x000000018978F080-0x000000018978F0A0
		public void Init(SECTR_GUID inSecGuid, Transform inTrans, AssetJobPriority p, SECTR_Manager.LoadGameObjectCallBack inCB) {} // 0x00000001848C2A80-0x00000001848C2B90
		// [XID] // 0x00000001897968B0-0x00000001897968D0
		public override void Release() {} // 0x00000001848C2C90-0x00000001848C2D40
		// [XID] // 0x000000018979E990-0x000000018979E9B0
		public override bool Execute() => default; // 0x00000001848C27B0-0x00000001848C28C0
	}

	public class SECTR_ReleaseScenePropContext : SECTRJob, IAutoAllocRecycle // TypeDefIndex: 20315
	{
		// Fields
		public BaseScenePropObject sobj; // 0x10

		// Constructors
		public SECTR_ReleaseScenePropContext() {} // 0x00000001848C3BC0-0x00000001848C3C60

		// Methods
		[BlackList] // 0x00000001897A60C0-0x00000001897A6100
		// [XID] // 0x00000001897A60C0-0x00000001897A6100
		public override void AutoAllocTypeFields() {} // 0x00000001848C36C0-0x00000001848C3760
		[BlackList] // 0x00000001897B05C0-0x00000001897B0600
		// [XID] // 0x00000001897B05C0-0x00000001897B0600
		public override void AutoRecycleTypeFields() {} // 0x00000001848C3760-0x00000001848C3810
		[BlackList] // 0x00000001897BB890-0x00000001897BB8D0
		// [XID] // 0x00000001897BB890-0x00000001897BB8D0
		public override void ReturnToObjectPool() {} // 0x00000001848C3B20-0x00000001848C3BC0
		// [XID] // 0x00000001897C6230-0x00000001897C6250
		public override SECTRJobType GetJobType() => default; // 0x00000001848C3980-0x00000001848C3A20
		// [XID] // 0x00000001897CDAA0-0x00000001897CDAC0
		public void Init(BaseScenePropObject obj) {} // 0x00000001848C3870-0x00000001848C3920
		// [XID] // 0x00000001897D4FF0-0x00000001897D5010
		public override void Release() {} // 0x00000001848C3A20-0x00000001848C3AC0
		// [XID] // 0x00000001897DC7B0-0x00000001897DC7D0
		public override bool Execute() => default; // 0x00000001848C3610-0x00000001848C36C0
	}

	public class SECTR_UnityThreadCBContext : SECTRJob, IAutoAllocRecycle // TypeDefIndex: 20316
	{
		// Fields
		public ISECTR_ThreadCB lodThread; // 0x10

		// Constructors
		public SECTR_UnityThreadCBContext() {} // 0x00000001848C3570-0x00000001848C3610

		// Methods
		[BlackList] // 0x00000001897E4170-0x00000001897E41B0
		// [XID] // 0x00000001897E4170-0x00000001897E41B0
		public override void AutoAllocTypeFields() {} // 0x00000001848C3070-0x00000001848C3110
		[BlackList] // 0x00000001897EEC20-0x00000001897EEC60
		// [XID] // 0x00000001897EEC20-0x00000001897EEC60
		public override void AutoRecycleTypeFields() {} // 0x00000001848C3110-0x00000001848C31C0
		[BlackList] // 0x00000001897F95F0-0x00000001897F9630
		// [XID] // 0x00000001897F95F0-0x00000001897F9630
		public override void ReturnToObjectPool() {} // 0x00000001848C34D0-0x00000001848C3570
		// [XID] // 0x0000000189803C50-0x0000000189803C70
		public override SECTRJobType GetJobType() => default; // 0x00000001848C3330-0x00000001848C33D0
		// [XID] // 0x000000018980B0D0-0x000000018980B0F0
		public void Init(ISECTR_ThreadCB lod) {} // 0x00000001848C3220-0x00000001848C32D0
		// [XID] // 0x0000000189812760-0x0000000189812780
		public override void Release() {} // 0x00000001848C33D0-0x00000001848C3470
		// [XID] // 0x000000018981A400-0x000000018981A420
		public override bool Execute() => default; // 0x00000001848C2FB0-0x00000001848C3070
	}

	public class SECTR_UnLoadObjContext : SECTRJob, IAutoAllocRecycle // TypeDefIndex: 20317
	{
		// Fields
		public SECTR_GUID secGuid; // 0x10
		public uint uid; // 0x18
		public bool isRecycle; // 0x1C

		// Constructors
		public SECTR_UnLoadObjContext() {} // 0x00000001848C4DF0-0x00000001848C4E90

		// Methods
		[BlackList] // 0x0000000189821AB0-0x0000000189821AF0
		// [XID] // 0x0000000189821AB0-0x0000000189821AF0
		public override void AutoAllocTypeFields() {} // 0x00000001848C48B0-0x00000001848C4950
		[BlackList] // 0x000000018982C1F0-0x000000018982C230
		// [XID] // 0x000000018982C1F0-0x000000018982C230
		public override void AutoRecycleTypeFields() {} // 0x00000001848C4950-0x00000001848C4A00
		[BlackList] // 0x0000000189836670-0x00000001898366B0
		// [XID] // 0x0000000189836670-0x00000001898366B0
		public override void ReturnToObjectPool() {} // 0x00000001848C4D50-0x00000001848C4DF0
		// [XID] // 0x0000000189840970-0x0000000189840990
		public override SECTRJobType GetJobType() => default; // 0x00000001848C4BA0-0x00000001848C4C40
		// [XID] // 0x0000000189847EC0-0x0000000189847EE0
		public void Init(SECTR_GUID inSecGuid, bool re) {} // 0x00000001848C4A60-0x00000001848C4B40
		// [XID] // 0x000000018984F640-0x000000018984F660
		public override void Release() {} // 0x00000001848C4C40-0x00000001848C4CF0
		// [XID] // 0x00000001898567E0-0x0000000189856800
		public override bool Execute() => default; // 0x00000001848C4760-0x00000001848C48B0
	}

	public class SECTR_VirtualPatternObjContext : SECTRJob, IAutoAllocRecycle // TypeDefIndex: 20318
	{
		// Fields
		public SECTR_VirtualPatternObj obj; // 0x10
		public SECTR_BaseObject sectrObj; // 0x18
		public bool isLoad; // 0x20

		// Constructors
		public SECTR_VirtualPatternObjContext() {} // 0x00000001848C5630-0x00000001848C56D0

		// Methods
		[BlackList] // 0x000000018985DA90-0x000000018985DAD0
		// [XID] // 0x000000018985DA90-0x000000018985DAD0
		public override void AutoAllocTypeFields() {} // 0x00000001848C5080-0x00000001848C5120
		[BlackList] // 0x0000000189868460-0x00000001898684A0
		// [XID] // 0x0000000189868460-0x00000001898684A0
		public override void AutoRecycleTypeFields() {} // 0x00000001848C5120-0x00000001848C51D0
		[BlackList] // 0x0000000189872850-0x0000000189872890
		// [XID] // 0x0000000189872850-0x0000000189872890
		public override void ReturnToObjectPool() {} // 0x00000001848C5590-0x00000001848C5630
		// [XID] // 0x000000018987D430-0x000000018987D450
		public override SECTRJobType GetJobType() => default; // 0x00000001848C53F0-0x00000001848C5490
		// [IDTag] // 0x00000001898842F0-0x0000000189884330
		// [XID] // 0x00000001898842F0-0x0000000189884330
		public void Init(SECTR_VirtualPatternObj o) {} // 0x00000001848C5230-0x00000001848C52E0
		// [IDTag] // 0x000000018988E6E0-0x000000018988E720
		// [XID] // 0x000000018988E6E0-0x000000018988E720
		public void Init(SECTR_BaseObject o) {} // 0x00000001848C52E0-0x00000001848C5390
		// [XID] // 0x0000000189898F30-0x0000000189898F50
		public override void Release() {} // 0x00000001848C5490-0x00000001848C5530
		// [XID] // 0x00000001898A0150-0x00000001898A0170
		public override bool Execute() => default; // 0x00000001848C4E90-0x00000001848C5080
	}

	public class SECTR_VolumeObjectContext : SECTRJob, IAutoAllocRecycle // TypeDefIndex: 20319
	{
		// Fields
		public ISECTR_BaseVolume obj; // 0x10
		public bool isLoad; // 0x18

		// Constructors
		public SECTR_VolumeObjectContext() {} // 0x000000018489F940-0x000000018489F9E0

		// Methods
		[BlackList] // 0x00000001898A7910-0x00000001898A7950
		// [XID] // 0x00000001898A7910-0x00000001898A7950
		public override void AutoAllocTypeFields() {} // 0x000000018489F420-0x000000018489F4C0
		[BlackList] // 0x00000001898B21B0-0x00000001898B21F0
		// [XID] // 0x00000001898B21B0-0x00000001898B21F0
		public override void AutoRecycleTypeFields() {} // 0x000000018489F4C0-0x000000018489F570
		[BlackList] // 0x00000001898BCB30-0x00000001898BCB70
		// [XID] // 0x00000001898BCB30-0x00000001898BCB70
		public override void ReturnToObjectPool() {} // 0x000000018489F8A0-0x000000018489F940
		// [XID] // 0x00000001898C7280-0x00000001898C72A0
		public override SECTRJobType GetJobType() => default; // 0x000000018489F700-0x000000018489F7A0
		// [XID] // 0x00000001898CE810-0x00000001898CE830
		public void Init(ISECTR_BaseVolume o, bool isLoad) {} // 0x000000018489F5D0-0x000000018489F6A0
		// [XID] // 0x00000001898D6220-0x00000001898D6240
		public override void Release() {} // 0x000000018489F7A0-0x000000018489F840
		// [XID] // 0x00000001898DDE00-0x00000001898DDE20
		public override bool Execute() => default; // 0x000000018489F2F0-0x000000018489F420
	}

	[RecycleType] // 0x00000001898422C0-0x00000001898422E0
	public abstract class SECTRJob : IAutoAllocRecycle, ISECTR_Reuseable // TypeDefIndex: 20320
	{
		// Constructors
		public SECTRJob() {} // 0x000000018489FD10-0x000000018489FD70

		// Methods
		[BlackList] // 0x00000001898ECFA0-0x00000001898ECFE0
		// [XID] // 0x00000001898ECFA0-0x00000001898ECFE0
		public virtual void AutoAllocTypeFields() {} // 0x000000018489F9E0-0x000000018489FA80
		[BlackList] // 0x00000001898F7A70-0x00000001898F7AB0
		// [XID] // 0x00000001898F7A70-0x00000001898F7AB0
		public virtual void AutoRecycleTypeFields() {} // 0x000000018489FA80-0x000000018489FB20
		[BlackList] // 0x00000001899021F0-0x0000000189902230
		// [XID] // 0x00000001899021F0-0x0000000189902230
		public virtual void ReturnToObjectPool() {} // 0x000000018489FC70-0x000000018489FD10
		// [XID] // 0x000000018990CAD0-0x000000018990CAF0
		public virtual void OnPoolAllocated() {} // 0x000000018489FBC0-0x000000018489FC70
		// [XID] // 0x0000000189914260-0x0000000189914280
		public virtual void OnBeforePoolRecycled() {} // 0x000000018489FB20-0x000000018489FBC0
		public abstract SECTRJobType GetJobType();
		public abstract bool Execute();
		public abstract void Release();
	}

	public enum ContextType // TypeDefIndex: 20321
	{
		Invalid = 0,
		LOD = 1,
		Collider = 2,
		Split = 3,
		Main = 4
	}

	public enum SECTRJobType // TypeDefIndex: 20322
	{
		ReleaseSceneProp = 0,
		LoadObject = 1,
		LoadByte = 2,
		VirtualObj = 3,
		UnloadObj = 4,
		MainThreadCB = 5,
		DelayAction = 6,
		VolumeObject = 7
	}

	// Constructors
	public SECTR_ThreadContext() {} // 0x00000001848C1D10-0x00000001848C1E30

	// Methods
	// [XID] // 0x0000000189642D40-0x0000000189642D60
	public int GetCachePosCount() => default; // 0x00000001848C0340-0x00000001848C0400
	// [XID] // 0x000000018964A390-0x000000018964A3B0
	public List<Vector3> GetCachePosList() => default; // 0x00000001848BFD90-0x00000001848BFE30
	// [XID] // 0x0000000189651AE0-0x0000000189651B00
	public bool ContainsCachePos(int id) => default; // 0x00000001848C1640-0x00000001848C1710
	// [XID] // 0x0000000189659350-0x0000000189659370
	public void RemoveCachePos(int id) {} // 0x00000001848C0910-0x00000001848C0AC0
	// [XID] // 0x0000000189660A10-0x0000000189660A30
	public void AddCachePos(int id, Vector3 pos) {} // 0x00000001848C0100-0x00000001848C0240
	// [XID] // 0x0000000189668460-0x0000000189668480
	public void InitThread(ContextType state) {} // 0x00000001848BFCE0-0x00000001848BFD90
	// [XID] // 0x000000018966FF10-0x000000018966FF30
	public void InitTaskData(int id, ITaskData data) {} // 0x00000001848BF930-0x00000001848BFAE0
	// [XID] // 0x0000000189677740-0x0000000189677760
	public void DestroyThread() {} // 0x00000001848C0240-0x00000001848C0340
	// [XID] // 0x000000018967ECE0-0x000000018967ED00
	public void AddSectrReleaseScenePropRequestComputeThread(BaseScenePropObject obj) {} // 0x00000001848C0C50-0x00000001848C0DE0
	// [XID] // 0x00000001896865D0-0x00000001896865F0
	public void AddSectrLoadObjectRequestComputeThread(SECTR_GUID inSecGuid, Transform inTrans, SECTR_Manager.LoadGameObjectCallBack inCallback, AssetJobPriority priority) {} // 0x00000001848C1870-0x00000001848C1D10
	// [XID] // 0x000000018968E430-0x000000018968E450
	public void AddSectrLoadByteArrayRequestComputeThread(SECTR_GUID inSecGuid, SECTR_Manager.LoadByteArrayCallBack inCallback, AssetJobPriority priority) {} // 0x00000001848C0400-0x00000001848C05C0
	// [XID] // 0x0000000189695C90-0x0000000189695CB0
	public void AddLoadVirtualObjectRequestComputeThread(SECTR_VirtualPatternObj obj) {} // 0x00000001848C0750-0x00000001848C0910
	// [XID] // 0x000000018969D400-0x000000018969D420
	public void AddUnloadVirtualObjectRequestComputeThread(SECTR_BaseObject obj) {} // 0x00000001848C05C0-0x00000001848C0750
	// [XID] // 0x00000001896A44C0-0x00000001896A44E0
	public void AddSectrUnLoadObjectRequestComputeThread(SECTR_GUID inSecGuid, bool isRecycle) {} // 0x00000001848BFE30-0x00000001848C0100
	// [XID] // 0x00000001896ABCD0-0x00000001896ABCF0
	public void AddLoadVolumeObjectRequestComputeThread(ISECTR_BaseVolume obj) {} // 0x00000001848C1060-0x00000001848C1200
	// [XID] // 0x00000001896B2E70-0x00000001896B2E90
	public void AddUnloadVolumeObjectRequestComputeThread(ISECTR_BaseVolume obj) {} // 0x00000001848C14A0-0x00000001848C1640
	// [XID] // 0x00000001896BA5F0-0x00000001896BA610
	public void AddSectrOnUnityThreadCBRequestComputeThread(ISECTR_ThreadCB inSVB) {} // 0x00000001848C0AC0-0x00000001848C0C50
	// [XID] // 0x00000001896C1780-0x00000001896C17A0
	public void AddSectrDelayActionRequestComputeThread(ISECTR_ThreadCB inSVB, float delayTime) {} // 0x00000001848C1200-0x00000001848C13D0
	// [XID] // 0x00000001896C8EA0-0x00000001896C8EC0
	private void HandleRequestInUnityThread(SECTR_JobList<SECTRJob> inRequests, SliceFrameWatch inWatch, SECTER_ContextGenerator generator) {} // 0x00000001848BFAE0-0x00000001848BFCE0
	// [XID] // 0x00000001896D0820-0x00000001896D0840
	public void ProcessRequestsInUnityThread(SliceFrameWatch targetWatch) {} // 0x00000001848C0E80-0x00000001848C1060
	// [XID] // 0x00000001896D7D70-0x00000001896D7D90
	public void HandleOneRequest() {} // 0x00000001848C1710-0x00000001848C1870
	// [XID] // 0x00000001896DF660-0x00000001896DF680
	public void MergeRequests(SECTR_JobList<SECTRJob> reqs) {} // 0x00000001848C13D0-0x00000001848C14A0
	// [XID] // 0x00000001896E69A0-0x00000001896E69C0
	public SECTR_JobList<SECTRJob> GetRequestList() => default; // 0x00000001848C0DE0-0x00000001848C0E80
}

