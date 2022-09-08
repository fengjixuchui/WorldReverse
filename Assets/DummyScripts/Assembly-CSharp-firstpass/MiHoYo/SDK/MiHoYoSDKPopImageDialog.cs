/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using IFix.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace MiHoYo.SDK
{
	internal class MiHoYoSDKPopImageDialog : MonoBehaviour // TypeDefIndex: 8868
	{
		// Fields
		private const string PopImagePrefabPath = "UI/PopImageDialog.Prefab"; // Metadata: 0x00AE3AA9
		private const string BGPath = "BG"; // Metadata: 0x00AE3AC5
		private const string ImagePath = "Dialog"; // Metadata: 0x00AE3ACB
		private const string CloseButtonPath = "Dialog/CloseBtn"; // Metadata: 0x00AE3AD5
		private const string JoyPadButtonsPath = "Dialog/JoyPadButtons"; // Metadata: 0x00AE3AE8
		private const string JoyPadCloseButtonPath = "CloseBtn"; // Metadata: 0x00AE3B00
		private const string JoyPadWatchButtonPath = "WatchBtn"; // Metadata: 0x00AE3B0C
		private const string JoyPadCloseButtonTextPath = "CloseText"; // Metadata: 0x00AE3B18
		private const string JoyPadWatchButtonTextPath = "WatchText"; // Metadata: 0x00AE3B25
		private const string JoyPadCircle = "CircleImage"; // Metadata: 0x00AE3B32
		private const string JoyPadClose = "CloseImage"; // Metadata: 0x00AE3B41
		private const string JoyPadXBoxA = "XBoxAImage"; // Metadata: 0x00AE3B4F
		private const string JoyPadXBoxB = "XBoxBImage"; // Metadata: 0x00AE3B5D
		private Button bgButton; // 0x18
		private GameObject imageObject; // 0x20
		private GameObject closeObject; // 0x28
		private GameObject joyPadObject; // 0x30
		private GameObject joyPadCloseObject; // 0x38
		private GameObject joyPadWatchObject; // 0x40
		private UnityEngine.UI.Text joyPadCloseText; // 0x48
		private UnityEngine.UI.Text joyPadWatchText; // 0x50
		private GameObject joyPadWatchCircleObject; // 0x58
		private GameObject joyPadWatchCloseObject; // 0x60
		private GameObject joyPadWatchAObject; // 0x68
		private GameObject joyPadWatchBObject; // 0x70
		private GameObject joyPadCloseCircleObject; // 0x78
		private GameObject joyPadCloseCloseObject; // 0x80
		private GameObject joyPadCloseAObject; // 0x88
		private GameObject joyPadCloseBObject; // 0x90
		private MiHoYoSDKPopImageModel _popImageModel; // 0xA8
	
		// Properties
		public MiHoYoSDKPopImageModel popImageModel { /* [XID] */ /* 0x0000000189653180-0x00000001896531A0 */ get => default; /* [XID] */ /* 0x00000001898C08B0-0x00000001898C08D0 */ set {} } // 0x000000018625E4C0-0x000000018625E570 0x000000018625E7B0-0x000000018625E900
	
		// Events
		public event CloseDelegate OnClose;
		public event ClickImageDelegate OnClickImage;
	
		// Nested types
		public delegate void CloseDelegate(MiHoYoSDKPopImageModel model); // TypeDefIndex: 8869; 0x0000000186251020-0x0000000186251280
	
		public delegate void ClickImageDelegate(MiHoYoSDKPopImageModel model); // TypeDefIndex: 8870; 0x0000000186250C30-0x0000000186250E90
	
		// Constructors
		public MiHoYoSDKPopImageDialog() {} // 0x000000018625E220-0x000000018625E280
	
		// Methods
		// [XID] // 0x000000018990AD80-0x000000018990ADA0
		public static MiHoYoSDKPopImageDialog Instance() => default; // 0x000000018625D530-0x000000018625D690
		// [XID] // 0x00000001898D71F0-0x00000001898D7210
		private void Awake() {} // 0x000000018625C920-0x000000018625D1F0
		// [XID] // 0x00000001898DEF90-0x00000001898DEFB0
		private void Update() {} // 0x000000018625DFA0-0x000000018625E220
		// [XID] // 0x00000001897AA340-0x00000001897AA360
		public void Hide() {} // 0x000000018625D440-0x000000018625D530
		// [XID] // 0x00000001899CC830-0x00000001899CC850
		public void Close() {} // 0x000000018625D360-0x000000018625D440
		// [XID] // 0x00000001896AC730-0x00000001896AC750
		private void ClickImage() {} // 0x000000018625D1F0-0x000000018625D360
		// [XID] // 0x00000001898FCF40-0x00000001898FCF60
		private void OnGetTexture(Texture2D data) {} // 0x000000018625D690-0x000000018625DBD0
		// [XID] // 0x00000001899048A0-0x00000001899048C0
		private void UpdateJoyPadButtonUI() {} // 0x000000018625DD50-0x000000018625DFA0
		// [XID] // 0x000000018990C090-0x000000018990C0B0
		private void RestJoyPadButtonUI() {} // 0x000000018625DBD0-0x000000018625DD50
	}
}
