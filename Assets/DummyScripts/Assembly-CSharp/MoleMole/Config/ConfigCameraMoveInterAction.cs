/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MihoyoOptimization;
using MoleMole;
using SimpleJSON;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole.Config
{
	[CSharpCallLua] // 0x000000018998DB20-0x000000018998DB60
	[RecycleType] // 0x000000018998DB20-0x000000018998DB60
	public class ConfigCameraMoveInterAction : ConfigBaseInterAction, IAutoAllocRecycle // TypeDefIndex: 18391
	{
		// Fields
		private StoryCameraPosType _cameraPosType; // 0x30
		private Vector _camPosOffset; // 0x34
		private float _nearLength; // 0x40
		private StoryCameraTargetType _camTargetType; // 0x44
		private Vector _camForwardTargetOffset; // 0x48
		private bool _needElev; // 0x54
		private float _camFov; // 0x58
		private float _camDutch; // 0x5C
		private float _lerpRatio; // 0x60
		private int _lerpPattern; // 0x64
		private TweenEaseType _cameraBlendType; // 0x68
		private bool _storyDither; // 0x6C
		// [PooledField] // 0x0000000189951E30-0x0000000189951E50
		private ConfigFrameTransition _cutFrameTrans; // 0x70
		private bool _needZAxisRotate; // 0x78
		private float _rotateAngle; // 0x7C
		private bool _openCameraDither; // 0x80
		private string _targetNpcAlias; // 0x88
		private bool _keepCameraPos; // 0x90
		private bool _useDurationWhenExitFocus; // 0x91
	
		// Properties
		public StoryCameraPosType cameraPosType { /* [XID] */ /* 0x00000001897B2130-0x00000001897B2150 */ get => default; /* [XID] */ /* 0x00000001897B9AD0-0x00000001897B9AF0 */ private set {} } // 0x0000000187E0B1A0-0x0000000187E0B240 0x0000000187E0BE90-0x0000000187E0BF40
		public Vector camPosOffset { /* [XID] */ /* 0x00000001897C1B70-0x00000001897C1B90 */ get => default; /* [XID] */ /* 0x00000001897C9540-0x00000001897C9560 */ private set {} } // 0x0000000187E0AF80-0x0000000187E0B060 0x0000000187E0BC60-0x0000000187E0BD30
		public float nearLength { /* [XID] */ /* 0x00000001897D0B30-0x00000001897D0B50 */ get => default; /* [XID] */ /* 0x00000001897D8910-0x00000001897D8930 */ private set {} } // 0x0000000187E0B4E0-0x0000000187E0B590 0x0000000187E0C200-0x0000000187E0C2B0
		public StoryCameraTargetType camTargetType { /* [XID] */ /* 0x00000001897DF9F0-0x00000001897DFA10 */ get => default; /* [XID] */ /* 0x00000001897E7070-0x00000001897E7090 */ private set {} } // 0x0000000187E0B060-0x0000000187E0B100 0x0000000187E0BD30-0x0000000187E0BDE0
		public Vector camForwardTargetOffset { /* [XID] */ /* 0x00000001897EEE70-0x00000001897EEE90 */ get => default; /* [XID] */ /* 0x00000001897F64E0-0x00000001897F6500 */ private set {} } // 0x0000000187E0ADF0-0x0000000187E0AED0 0x0000000187E0BAE0-0x0000000187E0BBB0
		public bool needElev { /* [XID] */ /* 0x00000001897FDC20-0x00000001897FDC40 */ get => default; /* [XID] */ /* 0x0000000189805370-0x0000000189805390 */ private set {} } // 0x0000000187E0B590-0x0000000187E0B630 0x0000000187E0C2B0-0x0000000187E0C360
		public float camFov { /* [XID] */ /* 0x000000018980C990-0x000000018980C9B0 */ get => default; /* [XID] */ /* 0x0000000189814110-0x0000000189814130 */ private set {} } // 0x0000000187E0AED0-0x0000000187E0AF80 0x0000000187E0BBB0-0x0000000187E0BC60
		public float camDutch { /* [XID] */ /* 0x000000018981BC80-0x000000018981BCA0 */ get => default; /* [XID] */ /* 0x0000000189823090-0x00000001898230B0 */ private set {} } // 0x0000000187E0AD40-0x0000000187E0ADF0 0x0000000187E0BA30-0x0000000187E0BAE0
		public float lerpRatio { /* [XID] */ /* 0x000000018982AAF0-0x000000018982AB10 */ get => default; /* [XID] */ /* 0x0000000189831FB0-0x0000000189831FD0 */ private set {} } // 0x0000000187E0B430-0x0000000187E0B4E0 0x0000000187E0C150-0x0000000187E0C200
		public int lerpPattern { /* [XID] */ /* 0x00000001898396A0-0x00000001898396C0 */ get => default; /* [XID] */ /* 0x0000000189840C80-0x0000000189840CA0 */ private set {} } // 0x0000000187E0B390-0x0000000187E0B430 0x0000000187E0C0A0-0x0000000187E0C150
		public TweenEaseType cameraBlendType { /* [XID] */ /* 0x00000001898480A0-0x00000001898480C0 */ get => default; /* [XID] */ /* 0x000000018984F800-0x000000018984F820 */ private set {} } // 0x0000000187E0B100-0x0000000187E0B1A0 0x0000000187E0BDE0-0x0000000187E0BE90
		public bool storyDither { /* [XID] */ /* 0x0000000189856A40-0x0000000189856A60 */ get => default; /* [XID] */ /* 0x000000018985DC90-0x000000018985DCB0 */ private set {} } // 0x0000000187E0B830-0x0000000187E0B8D0 0x0000000187E0C570-0x0000000187E0C620
		public ConfigFrameTransition cutFrameTrans { /* [XID] */ /* 0x0000000189865710-0x0000000189865730 */ get => default; /* [XID] */ /* 0x000000018986CBB0-0x000000018986CBD0 */ private set {} } // 0x0000000187E0B240-0x0000000187E0B2E0 0x0000000187E0BF40-0x0000000187E0BFF0
		public bool needZAxisRotate { /* [XID] */ /* 0x0000000189874040-0x0000000189874060 */ get => default; /* [XID] */ /* 0x000000018987BB20-0x000000018987BB40 */ private set {} } // 0x0000000187E0B630-0x0000000187E0B6D0 0x0000000187E0C360-0x0000000187E0C410
		public float rotateAngle { /* [XID] */ /* 0x0000000189882D10-0x0000000189882D30 */ get => default; /* [XID] */ /* 0x000000018988A4B0-0x000000018988A4D0 */ private set {} } // 0x0000000187E0B780-0x0000000187E0B830 0x0000000187E0C4C0-0x0000000187E0C570
		public bool openCameraDither { /* [XID] */ /* 0x0000000189891920-0x0000000189891940 */ get => default; /* [XID] */ /* 0x0000000189899270-0x0000000189899290 */ private set {} } // 0x0000000187E0B6D0-0x0000000187E0B780 0x0000000187E0C410-0x0000000187E0C4C0
		public string targetNpcAlias { /* [XID] */ /* 0x00000001898A0410-0x00000001898A0430 */ get => default; /* [XID] */ /* 0x00000001898A7B50-0x00000001898A7B70 */ private set {} } // 0x0000000187E0B8D0-0x0000000187E0B980 0x0000000187E0C620-0x0000000187E0C6D0
		public bool keepCameraPos { /* [XID] */ /* 0x00000001898AF6F0-0x00000001898AF710 */ get => default; /* [XID] */ /* 0x00000001898B6B50-0x00000001898B6B70 */ private set {} } // 0x0000000187E0B2E0-0x0000000187E0B390 0x0000000187E0BFF0-0x0000000187E0C0A0
		public bool useDurationWhenExitFocus { /* [XID] */ /* 0x00000001898BE300-0x00000001898BE320 */ get => default; /* [XID] */ /* 0x00000001898C5BD0-0x00000001898C5BF0 */ private set {} } // 0x0000000187E0B980-0x0000000187E0BA30 0x0000000187E0C6D0-0x0000000187E0C780
	
		// Constructors
		public ConfigCameraMoveInterAction() {} // 0x0000000187E0AC60-0x0000000187E0AD40
	
		// Methods
		// [XID] // 0x00000001898CD300-0x00000001898CD320
		public override void ObjectContentHashOnto(ref int hash_code) {} // 0x0000000187E09AD0-0x0000000187E09E00
		// [XID] // 0x00000001898D4BD0-0x00000001898D4BF0
		public override void ForeachRefTypeMember(Action<object> callback) {} // 0x0000000187E069B0-0x0000000187E06AB0
		// [XID] // 0x00000001898DC5F0-0x00000001898DC610
		public override ConfigBaseInterAction Clone(bool useObjectPool = false /* Metadata: 0x00AF9709 */) => default; // 0x0000000187E068D0-0x0000000187E069B0
		// [XID] // 0x00000001898E4060-0x00000001898E4080
		public override int GetHashNum() => default; // 0x0000000187E07130-0x0000000187E07200
		// [XID] // 0x00000001898EBBD0-0x00000001898EBBF0
		public override void InitEmpty() {} // 0x0000000187E07200-0x0000000187E07310
		[BlackList] // 0x00000001898F3300-0x00000001898F3340
		// [XID] // 0x00000001898F3300-0x00000001898F3340
		public override bool FromJson(JSONNode node) => default; // 0x0000000187E06DB0-0x0000000187E07130
		// [XID] // 0x00000001898FDC40-0x00000001898FDC60
		private new bool InternalFromJson(JSONNode node) => default; // 0x0000000187E07ED0-0x0000000187E08EA0
		[BlackList] // 0x00000001899053E0-0x0000000189905420
		// [XID] // 0x00000001899053E0-0x0000000189905420
		public static new ConfigCameraMoveInterAction ParseFromJson(JSONNode node) => default; // 0x0000000187E0A020-0x0000000187E0A270
		// [XID] // 0x000000018990FC50-0x000000018990FC70
		public override bool FromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF970A */, bool useObjectPool = false /* Metadata: 0x00AF970E */) => default; // 0x0000000187E06AB0-0x0000000187E06DB0
		// [XID] // 0x0000000189917760-0x0000000189917780
		private new bool InternalFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF970F */, bool useObjectPool = false /* Metadata: 0x00AF9713 */) => default; // 0x0000000187E07310-0x0000000187E07ED0
		// [XID] // 0x000000018991ED60-0x000000018991ED80
		public static new ConfigCameraMoveInterAction ParseFromBinary(ByteArray byteArray, int threadFlag = 0 /* Metadata: 0x00AF9714 */, bool useObjectPool = false /* Metadata: 0x00AF9718 */) => default; // 0x0000000187E09E00-0x0000000187E0A020
		[BlackList] // 0x0000000189926700-0x0000000189926740
		// [XID] // 0x0000000189926700-0x0000000189926740
		public override bool ToBinary(ByteArray byteArray) => default; // 0x0000000187E0A400-0x0000000187E0A6D0
		// [XID] // 0x0000000189930DA0-0x0000000189930DC0
		private new bool InternalToBinary(ByteArray byteArray) => default; // 0x0000000187E08EA0-0x0000000187E09AD0
		[BlackList] // 0x0000000189938110-0x0000000189938150
		// [XID] // 0x0000000189938110-0x0000000189938150
		public override bool SuperToBinary(ByteArray byteArray) => default; // 0x0000000187E0A310-0x0000000187E0A400
		[BlackList] // 0x0000000189942710-0x0000000189942750
		// [XID] // 0x0000000189942710-0x0000000189942750
		public override void AutoAllocTypeFields() {} // 0x0000000187E066A0-0x0000000187E06740
		[BlackList] // 0x000000018994CEB0-0x000000018994CEF0
		// [XID] // 0x000000018994CEB0-0x000000018994CEF0
		public override void AutoRecycleTypeFields() {} // 0x0000000187E06740-0x0000000187E068D0
		[BlackList] // 0x0000000189957740-0x0000000189957780
		// [XID] // 0x0000000189957740-0x0000000189957780
		public override void ReturnToObjectPool() {} // 0x0000000187E0A270-0x0000000187E0A310
	}
}
