/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoInLevelDebugAudioDialog : MonoBehaviour // TypeDefIndex: 30318
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _closeButton; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoTabGroup _tabs; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<GameObject> _tabsContent; // 0x28
		// [Header] // 0x000000018982BB10-0x000000018982BB60
		[SerializeField] // 0x000000018982BB10-0x000000018982BB60
		[Space] // 0x000000018982BB10-0x000000018982BB60
		private Dropdown _dropdownLanguage; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Image _imageGameState; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _buttonReloadAudioData; // 0x40
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _buttonReloadCullling; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _buttonClearCulling; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputField _inputCullingPattern; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _buttonCullingAdd; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _buttonCullingNotAdd; // 0x68
		// [Header] // 0x000000018986DDA0-0x000000018986DDF0
		[SerializeField] // 0x000000018986DDA0-0x000000018986DDF0
		[Space] // 0x000000018986DDA0-0x000000018986DDF0
		private InputField _inputEventName; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputField _inputEventRepeatCount; // 0x78
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _buttonPostEvent2D; // 0x80
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputField _inputSyncName; // 0x88
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _buttonSyncSetPlayer; // 0x90
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _buttonPostEventUseSync; // 0x98
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputField _inputPosX; // 0xA0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputField _inputPosY; // 0xA8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputField _inputPosZ; // 0xB0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputField _inputOffsetX; // 0xB8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputField _inputOffsetY; // 0xC0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputField _inputOffsetZ; // 0xC8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private InputField _inputOneTimeEventDuration; // 0xD0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _buttonSetPosUsePlayer; // 0xD8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Button _buttonPostEventUsePos; // 0xE0
		// [Header] // 0x00000001898E50F0-0x00000001898E5150
		[SerializeField] // 0x00000001898E50F0-0x00000001898E5150
		[Space] // 0x00000001898E50F0-0x00000001898E5150
		private Text _textPlayingCount; // 0xE8
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _textRegisterdGoCount; // 0xF0
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Text _textEventQueue; // 0xF8
	
		// Properties
		public Button closeButton { /* [XID] */ /* 0x0000000189903510-0x0000000189903530 */ get => default; } // 0x0000000184708D30-0x0000000184708DD0 
		public MonoTabGroup tabs { /* [XID] */ /* 0x000000018990AA60-0x000000018990AA80 */ get => default; } // 0x0000000184709710-0x00000001847097B0 
		public List<GameObject> tabsContent { /* [XID] */ /* 0x0000000189912710-0x0000000189912730 */ get => default; } // 0x0000000184709670-0x0000000184709710 
		public Dropdown dropdownLanguage { /* [XID] */ /* 0x0000000189919FE0-0x000000018991A000 */ get => default; } // 0x0000000184708DD0-0x0000000184708E70 
		public Image imageGameState { /* [XID] */ /* 0x0000000189921820-0x0000000189921840 */ get => default; } // 0x0000000184708E70-0x0000000184708F10 
		public Button buttonReloadCullling { /* [XID] */ /* 0x0000000189928F40-0x0000000189928F60 */ get => default; } // 0x0000000184708B30-0x0000000184708BD0 
		public Button buttonClearCulling { /* [XID] */ /* 0x00000001899304D0-0x00000001899304F0 */ get => default; } // 0x00000001847086A0-0x0000000184708740 
		public InputField inputCullingPattern { /* [XID] */ /* 0x00000001899379A0-0x00000001899379C0 */ get => default; } // 0x0000000184708F10-0x0000000184708FB0 
		public Button buttonCullingAdd { /* [XID] */ /* 0x000000018993F470-0x000000018993F490 */ get => default; } // 0x0000000184708740-0x00000001847087E0 
		public InputField inputEventName { /* [XID] */ /* 0x0000000189946A40-0x0000000189946A60 */ get => default; } // 0x0000000184708FB0-0x0000000184709050 
		public InputField inputEventRepeatCount { /* [XID] */ /* 0x000000018994E100-0x000000018994E120 */ get => default; } // 0x0000000184709050-0x00000001847090F0 
		public Button buttonPostEvent2D { /* [XID] */ /* 0x0000000189955700-0x0000000189955720 */ get => default; } // 0x0000000184708880-0x0000000184708930 
		public InputField inputSyncName { /* [XID] */ /* 0x000000018995D220-0x000000018995D240 */ get => default; } // 0x00000001847095C0-0x0000000184709670 
		public Button buttonSyncSetPlayer { /* [XID] */ /* 0x00000001899648D0-0x00000001899648F0 */ get => default; } // 0x0000000184708C80-0x0000000184708D30 
		public Button buttonPostEventUseSync { /* [XID] */ /* 0x000000018996BF50-0x000000018996BF70 */ get => default; } // 0x00000001847089E0-0x0000000184708A90 
		public InputField inputPosX { /* [XID] */ /* 0x0000000189973A40-0x0000000189973A60 */ get => default; } // 0x00000001847093B0-0x0000000184709460 
		public InputField inputPosY { /* [XID] */ /* 0x000000018997B0B0-0x000000018997B0D0 */ get => default; } // 0x0000000184709460-0x0000000184709510 
		public InputField inputPosZ { /* [XID] */ /* 0x0000000189982BE0-0x0000000189982C00 */ get => default; } // 0x0000000184709510-0x00000001847095C0 
		public InputField inputOffsetX { /* [XID] */ /* 0x000000018998A3B0-0x000000018998A3D0 */ get => default; } // 0x00000001847090F0-0x00000001847091A0 
		public InputField inputOffsetY { /* [XID] */ /* 0x0000000189991CA0-0x0000000189991CC0 */ get => default; } // 0x00000001847091A0-0x0000000184709250 
		public InputField inputOffsetZ { /* [XID] */ /* 0x0000000189999990-0x00000001899999B0 */ get => default; } // 0x0000000184709250-0x0000000184709300 
		public Button buttonSetPosUsePlayer { /* [XID] */ /* 0x00000001899A1060-0x00000001899A1080 */ get => default; } // 0x0000000184708BD0-0x0000000184708C80 
		public Button buttonPostEventUsePos { /* [XID] */ /* 0x00000001899A8B70-0x00000001899A8B90 */ get => default; } // 0x0000000184708930-0x00000001847089E0 
		public InputField inputOneTimeEventDuration { /* [XID] */ /* 0x00000001899B0470-0x00000001899B0490 */ get => default; } // 0x0000000184709300-0x00000001847093B0 
		public Button buttonReloadAudioData { /* [XID] */ /* 0x00000001899B77A0-0x00000001899B77C0 */ get => default; } // 0x0000000184708A90-0x0000000184708B30 
		public Button buttonCullingNotAdd { /* [XID] */ /* 0x00000001899BF140-0x00000001899BF160 */ get => default; } // 0x00000001847087E0-0x0000000184708880 
		public Text textPlayingCount { /* [XID] */ /* 0x00000001899C6AC0-0x00000001899C6AE0 */ get => default; } // 0x0000000184709860-0x0000000184709910 
		public Text textRegisterdGoCount { /* [XID] */ /* 0x00000001899CE040-0x00000001899CE060 */ get => default; } // 0x0000000184709910-0x00000001847099C0 
		public Text textEventQueue { /* [XID] */ /* 0x00000001899D57E0-0x00000001899D5800 */ get => default; } // 0x00000001847097B0-0x0000000184709860 
	
		// Constructors
		public MonoInLevelDebugAudioDialog() {} // 0x0000000184708640-0x00000001847086A0
	}
}
