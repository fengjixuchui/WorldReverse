/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using XLua;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	[LuaCallCSharp] // 0x0000000189BA67A0-0x0000000189BA67C0
	public struct ActorInfoData : ILuaActorInfoData // TypeDefIndex: 21062
	{
		// Fields
		private uint _runtimeID; // 0x00
		private string _alias; // 0x08
		private string _metaPath; // 0x10
		private uint _configID; // 0x18
		private uint _dataIndex; // 0x1C
		private Vector3 _bornPos; // 0x20
		private Vector3 _bornEuler; // 0x2C
		private bool _isNetwork; // 0x38
		private bool _isAutoStart; // 0x39
		private int _sceneID; // 0x3C
		private bool _noPerform; // 0x40
		private uint _roomID; // 0x44
		private uint _questID; // 0x48
		private bool _checkHide; // 0x4C
		private bool _dontDestroyOnClear; // 0x4D
		private bool _clearCmd; // 0x4E
	
		// Properties
		public uint runtimeID { /* [XID] */ /* 0x00000001896025E0-0x0000000189602600 */ get => default; /* [XID] */ /* 0x0000000189609E50-0x0000000189609E70 */ set {} } // 0x0000000181A42EC0-0x0000000181A42F70 0x0000000181A43B30-0x0000000181A43BF0
		public string alias { /* [XID] */ /* 0x00000001896116C0-0x00000001896116E0 */ get => default; /* [XID] */ /* 0x0000000189618F80-0x0000000189618FA0 */ set {} } // 0x0000000181A42460-0x0000000181A42550 0x0000000181A43030-0x0000000181A43110
		public string metaPath { /* [XID] */ /* 0x00000001896204C0-0x00000001896204E0 */ get => default; /* [XID] */ /* 0x0000000189919AE0-0x0000000189919B00 */ set {} } // 0x0000000181A42C00-0x0000000181A42CB0 0x0000000181A43830-0x0000000181A438F0
		public uint configID { /* [XID] */ /* 0x000000018962F370-0x000000018962F390 */ get => default; /* [XID] */ /* 0x0000000189921070-0x0000000189921090 */ set {} } // 0x0000000181A42890-0x0000000181A42940 0x0000000181A43470-0x0000000181A43530
		public uint dataIndex { /* [XID] */ /* 0x000000018963E360-0x000000018963E380 */ get => default; /* [XID] */ /* 0x0000000189928AB0-0x0000000189928AD0 */ set {} } // 0x0000000181A42940-0x0000000181A429F0 0x0000000181A43530-0x0000000181A435F0
		public Vector3 bornPos { /* [XID] */ /* 0x000000018964D440-0x000000018964D460 */ get => default; /* [XID] */ /* 0x0000000189654C80-0x0000000189654CA0 */ set {} } // 0x0000000181A42660-0x0000000181A42730 0x0000000181A43210-0x0000000181A432F0
		public Vector3 bornEuler { /* [XID] */ /* 0x000000018965C210-0x000000018965C230 */ get => default; /* [XID] */ /* 0x0000000189663A00-0x0000000189663A20 */ set {} } // 0x0000000181A42550-0x0000000181A42660 0x0000000181A43110-0x0000000181A43210
		public bool isNetwork { /* [XID] */ /* 0x000000018966B260-0x000000018966B280 */ get => default; /* [XID] */ /* 0x00000001899464F0-0x0000000189946510 */ set {} } // 0x0000000181A42B50-0x0000000181A42C00 0x0000000181A43770-0x0000000181A43830
		public bool isAutoStart { /* [XID] */ /* 0x000000018967A550-0x000000018967A570 */ get => default; /* [XID] */ /* 0x0000000189681E30-0x0000000189681E50 */ set {} } // 0x0000000181A42AA0-0x0000000181A42B50 0x0000000181A436B0-0x0000000181A43770
		public int sceneID { /* [XID] */ /* 0x0000000189689880-0x00000001896898A0 */ get => default; /* [XID] */ /* 0x00000001896915E0-0x0000000189691600 */ set {} } // 0x0000000181A42F70-0x0000000181A43030 0x0000000181A43BF0-0x0000000181A43D70
		public bool noPerform { /* [XID] */ /* 0x0000000189698C50-0x0000000189698C70 */ get => default; /* [XID] */ /* 0x00000001896A0110-0x00000001896A0130 */ set {} } // 0x0000000181A42CB0-0x0000000181A42D60 0x0000000181A438F0-0x0000000181A439B0
		public uint roomID { /* [XID] */ /* 0x00000001896A7480-0x00000001896A74A0 */ get => default; /* [XID] */ /* 0x00000001896AE960-0x00000001896AE980 */ set {} } // 0x0000000181A42E10-0x0000000181A42EC0 0x0000000181A43A70-0x0000000181A43B30
		public uint questID { /* [XID] */ /* 0x00000001896B6160-0x00000001896B6180 */ get => default; /* [XID] */ /* 0x0000000189964390-0x00000001899643B0 */ set {} } // 0x0000000181A42D60-0x0000000181A42E10 0x0000000181A439B0-0x0000000181A43A70
		public bool checkHide { /* [XID] */ /* 0x00000001896C4940-0x00000001896C4960 */ get => default; /* [XID] */ /* 0x00000001896CBEB0-0x00000001896CBED0 */ set {} } // 0x0000000181A42730-0x0000000181A427E0 0x0000000181A432F0-0x0000000181A433B0
		public bool dontDestroyOnClear { /* [XID] */ /* 0x00000001896D31C0-0x00000001896D31E0 */ get => default; /* [XID] */ /* 0x00000001899735C0-0x00000001899735E0 */ set {} } // 0x0000000181A429F0-0x0000000181A42AA0 0x0000000181A435F0-0x0000000181A436B0
		public bool clearCmd { /* [XID] */ /* 0x00000001896E2520-0x00000001896E2540 */ get => default; /* [XID] */ /* 0x000000018997AD20-0x000000018997AD40 */ set {} } // 0x0000000181A427E0-0x0000000181A42890 0x0000000181A433B0-0x0000000181A43470
	
		// Methods
		// [IDTag] // 0x00000001895ED750-0x00000001895ED790
		// [XID] // 0x00000001895ED750-0x00000001895ED790
		public static ActorInfoData GetActorInfoData(LocalEntityInfoData infoData) => default; // 0x0000000181A40C60-0x0000000181A417B0
		// [IDTag] // 0x00000001895F8010-0x00000001895F8050
		// [XID] // 0x00000001895F8010-0x00000001895F8050
		public static ActorInfoData GetActorInfoData(string alias, string metaPath, uint configID, Vector3 bornPos, Vector3 bornEuler, uint runtimeID = 0 /* Metadata: 0x00AFED8D */, uint dataIndex = 0 /* Metadata: 0x00AFED91 */, int sceneID = -1 /* Metadata: 0x00AFED95 */, bool isNetwork = true /* Metadata: 0x00AFED99 */, bool isAutoStart = true /* Metadata: 0x00AFED9A */, bool noPerform = true /* Metadata: 0x00AFED9B */, uint roomID = 0 /* Metadata: 0x00AFED9C */, uint questID = 0 /* Metadata: 0x00AFEDA0 */, bool checkHide = false /* Metadata: 0x00AFEDA4 */, bool dontDestroyOnClear = false /* Metadata: 0x00AFEDA5 */, bool clearCmd = false /* Metadata: 0x00AFEDA6 */) => default; // 0x0000000181A417B0-0x0000000181A42460
	}
}
