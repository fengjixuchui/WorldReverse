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

namespace CTS
{
	public class CTSDemoController : MonoBehaviour // TypeDefIndex: 9121
	{
		// Fields
		// [Header] // 0x00000001897E6870-0x00000001897E68A0
		public GameObject m_target; // 0x18
		// [Header] // 0x00000001897EFAB0-0x00000001897EFAE0
		public CTSWalk m_walkController; // 0x20
		private CharacterController m_characterController; // 0x28
		private Vector3 m_walkPos; // 0x30
		private Quaternion m_walkRotation; // 0x3C
		// [Header] // 0x00000001897F8B80-0x00000001897F8BB0
		public CTSFly m_flyController; // 0x50
		private Vector3 m_flyPos; // 0x58
		private Quaternion m_flyRotation; // 0x64
		// [Header] // 0x0000000189801B50-0x0000000189801B80
		public CTSLook m_lookController; // 0x78
		// [Header] // 0x000000018980A860-0x000000018980A890
		public CTSProfile m_unityProfile; // 0x80
		public CTSProfile m_basicProfile; // 0x88
		public CTSProfile m_advancedProfile; // 0x90
		public CTSProfile m_tesselatedProfile; // 0x98
		// [Header] // 0x0000000189813590-0x00000001898135C0
		public UnityEngine.UI.Text m_mode; // 0xA0
		public UnityEngine.UI.Text m_readme; // 0xA8
		public UnityEngine.UI.Text m_instructions; // 0xB0
		// [Header] // 0x000000018981C7F0-0x000000018981C820
		public ScriptableObject m_postFX; // 0xB8
		private Component m_postProcessingComponent; // 0xC0
		private Vector3 m_startPos; // 0xC8
		private Quaternion m_startRotation; // 0xD4
	
		// Constructors
		public CTSDemoController() {} // 0x0000000186423160-0x00000001864231C0
	
		// Methods
		// [XID] // 0x0000000189825540-0x0000000189825560
		private void Awake() {} // 0x0000000186420C50-0x0000000186421A00
		// [XID] // 0x000000018964A760-0x000000018964A780
		public void SelectUnity() {} // 0x0000000186422980-0x0000000186422B10
		// [XID] // 0x00000001898344B0-0x00000001898344D0
		public void SelectBasic() {} // 0x0000000186422660-0x00000001864227F0
		// [XID] // 0x000000018962F6E0-0x000000018962F700
		public void SelectAdvanced() {} // 0x00000001864224D0-0x0000000186422660
		// [XID] // 0x0000000189843300-0x0000000189843320
		public void SelectTesselated() {} // 0x00000001864227F0-0x0000000186422980
		// [XID] // 0x0000000189AE8150-0x0000000189AE8170
		public void Home() {} // 0x00000001864220D0-0x0000000186422340
		// [XID] // 0x0000000189851AE0-0x0000000189851B00
		public void Fly() {} // 0x0000000186421A00-0x0000000186421DC0
		// [XID] // 0x00000001898593D0-0x00000001898593F0
		public void Walk() {} // 0x0000000186422DA0-0x0000000186423160
		// [XID] // 0x0000000189A034D0-0x0000000189A034F0
		public void PostFX() {} // 0x0000000186422340-0x00000001864224D0
		// [XID] // 0x0000000189867AF0-0x0000000189867B10
		private void Update() {} // 0x0000000186422B10-0x0000000186422DA0
		// [XID] // 0x000000018986F180-0x000000018986F1A0
		public static System.Type GetType(string TypeName) => default; // 0x0000000186421DC0-0x00000001864220D0
	}
}
