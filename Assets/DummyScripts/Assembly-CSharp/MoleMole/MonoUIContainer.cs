/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
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
	public class MonoUIContainer : MonoBehaviour // TypeDefIndex: 30964
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public GameObject templatePrefab; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public List<string> textNames; // 0x20
		public List<string> textValues; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public List<string> spriteNames; // 0x30
		public List<Sprite> spriteValues; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public MonoAudioEvent2D.Event[] audioEvents; // 0x40
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool useDefaultText; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		public bool useAutoDisable; // 0x49
		private GameObject _instance; // 0x50
		private string _cacheText; // 0x58
		private const string _btnTagRecommendPath = "ART/UI/Menus/Widget/Btn_Tag_Recommend"; // Metadata: 0x00B11AF6
		private GameObject _recommendObj; // 0x60
		private uint _btnTagRecommendHandle; // 0x68
	
		// Properties
		public bool showRecommend { /* [XID] */ /* 0x0000000189924770-0x0000000189924790 */ set {} } // 0x0000000184894A60-0x0000000184894C60
	
		// Constructors
		public MonoUIContainer() {} // 0x00000001848949E0-0x0000000184894A60
	
		// Methods
		// [XID] // 0x00000001898BAF50-0x00000001898BAF70
		public void OnEnable() {} // 0x00000001848942B0-0x0000000184894510
		// [XID] // 0x00000001898C2280-0x00000001898C22A0
		public string PrintInstanceID() => default; // 0x0000000184894510-0x0000000184894670
		// [XID] // 0x00000001898C9D00-0x00000001898C9D20
		private void OnDestroy() {} // 0x0000000184894160-0x00000001848942B0
		// [XID] // 0x00000001898D1300-0x00000001898D1320
		public void InitTemplate() {} // 0x0000000184893BD0-0x0000000184893D50
		// [XID] // 0x00000001898D8B70-0x00000001898D8B90
		private void InitText() {} // 0x0000000184893D50-0x0000000184894160
		// [XID] // 0x00000001898E0870-0x00000001898E0890
		private void InitImage() {} // 0x0000000184893080-0x00000001848932D0
		// [XID] // 0x00000001898E83D0-0x00000001898E83F0
		public Button GetButton() => default; // 0x00000001848937E0-0x0000000184893920
		// [XID] // 0x00000001898EFAC0-0x00000001898EFAE0
		public UIDButton GetUIDButton() => default; // 0x0000000184893A90-0x0000000184893BD0
		// [XID] // 0x00000001898F7390-0x00000001898F73B0
		public Transform GetButtonIcon() => default; // 0x0000000184893540-0x00000001848936D0
		// [XID] // 0x00000001898FEB00-0x00000001898FEB20
		public void Clear() {} // 0x00000001848932D0-0x0000000184893420
		public new T GetComponent<T>() => default;
		// [XID] // 0x0000000189906220-0x0000000189906240
		public Transform Find(string path) => default; // 0x0000000184893420-0x0000000184893540
		// [XID] // 0x000000018990DCC0-0x000000018990DCE0
		public void SetButtonText(string btnText) {} // 0x00000001848948C0-0x00000001848949E0
		// [XID] // 0x0000000189915490-0x00000001899154B0
		public string GetButtonText() => default; // 0x00000001848936D0-0x00000001848937E0
		// [XID] // 0x000000018991CEE0-0x000000018991CF00
		public void SetButtonTextEx(string btnText) {} // 0x0000000184894670-0x00000001848948C0
		// [XID] // 0x000000018992BD20-0x000000018992BD40
		public Transform GetTagAttachPoint() => default; // 0x0000000184893920-0x0000000184893A90
	}
}
