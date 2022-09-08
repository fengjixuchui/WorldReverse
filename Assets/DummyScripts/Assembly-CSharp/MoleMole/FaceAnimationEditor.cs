/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using MoleMole.Config;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class FaceAnimationEditor : MonoBehaviour // TypeDefIndex: 19821
	{
		// Fields
		public FaceAnimationSettingItem[] faceAnimationSettingItems; // 0x18
		public Transform camPosTrans0; // 0x20
		public Transform camPosTrans1; // 0x28
		public Transform camFocTrans0; // 0x30
		public Transform camFocTrans1; // 0x38
		public Transform camMenuPos; // 0x40
		public Transform avatarMenuPos; // 0x48
		public float camFactor; // 0x50
		public float rotation; // 0x54
		public float angleOfPitch; // 0x58
		public float heightOffset; // 0x5C
		public bool menuCameraMode; // 0x60
		private FaceAnimationSettingItem _currentSettingItem; // 0x68
		private ConfigFaceAnimation _currentConfig; // 0x70
		private FaceAnimationEditAvatar[] _avatars; // 0x78
		private FaceAnimationEditAvatar _currentAvatar; // 0x80
		private int _currentAvatarIndex; // 0x88
		private int _currentFaceAnimationItemIndex; // 0x8C
		public float faceAnimationPanelHeight; // 0x90
		public float selectPanelWidth; // 0x94
		public float blockEditPanelWidth; // 0x98
		public float camFactorViewHeight; // 0x9C
		public float timePerFrameMin; // 0xA0
		public float timePerFrameMax; // 0xA4
		public float frameWidth; // 0xA8
		public float frameButtonFactor; // 0xAC
		public Animation cameraAnimation; // 0xB0
		public MonoSimpleAnimation simpleAnimation; // 0xB8
		public Transform cameraAnimationRoot; // 0xC0
		public float cameraAnimFOV; // 0xC8
		public Transform cameraAnimTarget; // 0xD0
		public Vector3 cameraAnimKeyedRotation; // 0xD8
		private FacePartType _currentPart; // 0xE4
		private float _normalizedTime; // 0xE8
		private bool _playing; // 0xEC
		private Animator _animator; // 0xF0
		private bool _activeCameraAnimation; // 0xF8
		private Vector2 _faceAnimationListScrollPos; // 0xFC
		private Vector2 _blockEditViewScrollPos; // 0x104
		private Vector2 _clipboardScrollPos; // 0x10C
		private Vector2 _contentViewScrollPos; // 0x114
		private bool _useAnimator; // 0x11C
		private string _animatorStateName; // 0x120
		private int _heartLevel; // 0x128
		private int _action; // 0x12C
		private int _eyeCopyDirection; // 0x130
		private string _mouthMultiEditSourceValue; // 0x138
		private string _mouthMultiEditTargetValue; // 0x140
		private int selectIndex; // 0x148
		private int selectCount; // 0x14C
		private List<FaceAnimationFrameBlock> _clipBoard; // 0x150
		private bool _changed; // 0x170
	
		// Properties
		public bool running { get; /* [XID] */ /* 0x00000001898EEA80-0x00000001898EEAC0 */ set; } // 0x0000000181F7A4A0-0x0000000181F7A500 0x0000000181F7A7E0-0x0000000181F7A850
		public bool openned { /* [XID] */ /* 0x00000001898F9270-0x00000001898F92B0 */ get; set; } // 0x0000000181F7A440-0x0000000181F7A4A0 0x0000000181F7A770-0x0000000181F7A7E0
		public string currentFilePath { /* [XID] */ /* 0x000000018990B170-0x000000018990B1B0 */ get; set; } // 0x0000000181F7A3E0-0x0000000181F7A440 0x0000000181F7A700-0x0000000181F7A770
		public bool changed { /* [XID] */ /* 0x000000018992C300-0x000000018992C320 */ get => default; /* [XID] */ /* 0x00000001899338A0-0x00000001899338C0 */ set {} } // 0x0000000181F7A330-0x0000000181F7A3E0 0x0000000181F7A620-0x0000000181F7A700
	
		// Events
		public event ChangedHandler Changed;
	
		// Nested types
		public enum FacePartType // TypeDefIndex: 19822
		{
			LeftEye = 0,
			RightEye = 1,
			Mouth = 2
		}
	
		public delegate void ChangedHandler(bool changed); // TypeDefIndex: 19823; 0x0000000181F6FF00-0x0000000181F70090
	
		// Constructors
		public FaceAnimationEditor() {} // 0x0000000181F7A000-0x0000000181F7A210
	
		// Methods
		// [XID] // 0x000000018993B470-0x000000018993B490
		private void Awake() {} // 0x0000000181F71160-0x0000000181F712C0
		// [XID] // 0x0000000189942570-0x0000000189942590
		private void Start() {} // 0x0000000181F79590-0x0000000181F79660
		// [XID] // 0x0000000189949F00-0x0000000189949F20
		public void Init() {} // 0x0000000181F75830-0x0000000181F75920
		// [XID] // 0x0000000189951A20-0x0000000189951A40
		public void Refresh() {} // 0x0000000181F794E0-0x0000000181F79590
		// [XID] // 0x0000000189958F30-0x0000000189958F50
		private void SwitchAvatarGameObject() {} // 0x0000000181F74D60-0x0000000181F75120
		// [XID] // 0x00000001899606E0-0x0000000189960700
		private void Update() {} // 0x0000000181F79660-0x0000000181F7A000
		// [XID] // 0x0000000189967FC0-0x0000000189967FE0
		private void DrawCamFactor() {} // 0x0000000181F78430-0x0000000181F78C70
		// [XID] // 0x000000018996F240-0x000000018996F260
		private void DrawAnimationSelectGUI() {} // 0x0000000181F75D20-0x0000000181F76E10
		// [XID] // 0x0000000189976EB0-0x0000000189976ED0
		private void DrawAnimationPanelGUI() {} // 0x0000000181F73CE0-0x0000000181F74D60
		// [XID] // 0x000000018997E220-0x000000018997E240
		private string GetMarkSymbolFromFacePart(FacePartType facePart) => default; // 0x0000000181F792B0-0x0000000181F793C0
		// [XID] // 0x0000000189985D50-0x0000000189985D70
		private void DrawAnimationBlocksView() {} // 0x0000000181F71D20-0x0000000181F73340
		// [XID] // 0x000000018998D9A0-0x000000018998D9C0
		private void DrawAnimationContentEditPanel() {} // 0x0000000181F772D0-0x0000000181F77C40
		// [XID] // 0x00000001899953F0-0x0000000189995410
		private void DrawClipboard() {} // 0x0000000181F76E10-0x0000000181F770B0
		// [XID] // 0x000000018999CEF0-0x000000018999CF10
		private void DrawSwitchView(int avatarIndex, out int out_avatarIndex, float width = 120f /* Metadata: 0x00AFCEFC */) {
			out_avatarIndex = default;
		} // 0x0000000181F73590-0x0000000181F73A60
		// [XID] // 0x00000001899A4810-0x00000001899A4830
		private void InitConfigs() {} // 0x0000000181F78290-0x0000000181F78430
		// [XID] // 0x00000001899AC150-0x00000001899AC170
		private FaceAnimationSettingItem GetSettingItemByName(string name) => default; // 0x0000000181F75BB0-0x0000000181F75D20
		// [XID] // 0x00000001899B39C0-0x00000001899B39E0
		private void InitAvatars() {} // 0x0000000181F75270-0x0000000181F755A0
		// [XID] // 0x00000001899BAE00-0x00000001899BAE20
		private void InitWwise() {} // 0x0000000181F73A60-0x0000000181F73B00
		// [XID] // 0x00000001899C2790-0x00000001899C27B0
		private string[] GetFaceAnimationItemNameArray() => default; // 0x0000000181F712C0-0x0000000181F71450
		// [XID] // 0x00000001899C9E80-0x00000001899C9EA0
		private bool DrawBlockGraphArray(FaceAnimationFrameBlock[] blocks, IFaceMatInfoProvider provider, int totalLength, float width, Color color0, Color color1, bool halfColor = false /* Metadata: 0x00AFCF00 */) => default; // 0x0000000181F78C70-0x0000000181F792B0
		// [XID] // 0x00000001899D1740-0x00000001899D1760
		private int MapFromNameToIndex(string name) => default; // 0x0000000181F780D0-0x0000000181F78290
		// [XID] // 0x00000001899D8C30-0x00000001899D8C50
		private string MapFromIndexToName(int index) => default; // 0x0000000181F755A0-0x0000000181F75700
		// [XID] // 0x00000001899E02C0-0x00000001899E02E0
		private int GetImageMapLength() => default; // 0x0000000181F75700-0x0000000181F75830
		// [XID] // 0x00000001899E7E40-0x00000001899E7E60
		private void Copy() {} // 0x0000000181F73B00-0x0000000181F73CE0
		// [XID] // 0x00000001899EF220-0x00000001899EF240
		private void PasteIndex() {} // 0x0000000181F71450-0x0000000181F71740
		// [XID] // 0x00000001899F6B90-0x00000001899F6BB0
		private void PasteTail() {} // 0x0000000181F77DE0-0x0000000181F780D0
		// [XID] // 0x00000001899FE250-0x00000001899FE270
		private FaceAnimationFrameBlock[] GetCurrentBlocks() => default; // 0x0000000181F71B40-0x0000000181F71D20
		// [XID] // 0x0000000189A05B30-0x0000000189A05B50
		private FaceAnimationFrameBlock[] CreateInverseEyeBlocks(FaceAnimationFrameBlock[] src, char replaceFrom, char replaceTo) => default; // 0x0000000181F73340-0x0000000181F73590
		// [XID] // 0x0000000189A0CE40-0x0000000189A0CE60
		private void UpdateHotkey() {} // 0x0000000181F71740-0x0000000181F71B40
		// [XID] // 0x0000000189A146A0-0x0000000189A146C0
		private bool CheckSelectFrameGroupSame() => default; // 0x0000000181F77C40-0x0000000181F77DE0
		// [XID] // 0x0000000189A1BA10-0x0000000189A1BA30
		private void ApplyMouthMultiEdit() {} // 0x0000000181F770B0-0x0000000181F772D0
		// [XID] // 0x0000000189A23320-0x0000000189A23340
		private string GetSpriteGroupName(string name) => default; // 0x0000000181F75120-0x0000000181F75270
		// [XID] // 0x0000000189A2A560-0x0000000189A2A580
		private string ReplaceSpriteGroupName(string name, string rpl) => default; // 0x0000000181F75920-0x0000000181F75BB0
		// [XID] // 0x0000000189A31A90-0x0000000189A31AB0
		private void RefreshAnimationStateName() {} // 0x0000000181F793C0-0x0000000181F794E0
	}
}
