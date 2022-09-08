/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;
using UnityEngine.Events;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoBillboard : MonoBehaviour // TypeDefIndex: 29700
	{
		// Fields
		[SerializeField] // 0x00000001899857A0-0x00000001899857D0
		[Space] // 0x00000001899857A0-0x00000001899857D0
		private RectTransform _avatarBoard; // 0x18
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _speechBubbleContainer; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _generalMarkContainer; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private RectTransform _elementReactionContainer; // 0x30
		[SerializeField] // 0x00000001899648A0-0x00000001899648D0
		[Space] // 0x00000001899648A0-0x00000001899648D0
		private Transform _owner; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MonoAsyncPrefabPlugin _asyncPrefabPlugin; // 0x40
		// [Header] // 0x0000000189AEDB20-0x0000000189AEDB50
		public Color none; // 0x48
		public Color fire; // 0x58
		public Color water; // 0x68
		public Color grass; // 0x78
		public Color electric; // 0x88
		public Color ice; // 0x98
		public Color wind; // 0xA8
		public Color rock; // 0xB8
		// [Header] // 0x00000001899C6C40-0x00000001899C6C70
		public Color back_none; // 0xC8
		public Color back_fire; // 0xD8
		public Color back_water; // 0xE8
		public Color back_grass; // 0xF8
		public Color back_electric; // 0x108
		public Color back_ice; // 0x118
		public Color back_wind; // 0x128
		public Color back_rock; // 0x138
		// [Header] // 0x0000000189AF5350-0x0000000189AF5380
		public Color friendHPColor; // 0x148
		public Color friendHPBgColor; // 0x158
		public Color enemyHPColor; // 0x168
		public Color enemyHPBgColor; // 0x178
		private MonoCombatBillboard _combatBillboard; // 0x188
		private UnityAction _callBackInitCombatBillboard; // 0x190
		private int _currSize; // 0x198
		private readonly string[] avatarBoardNames; // 0x1A0
		private MonoSpeechBubble _speechBubble; // 0x1A8
		private MonoProgressBillboard _progress; // 0x1B0
		private string _prefabPluginName; // 0x1B8
		private MonoArrowPointRecon _reconBoard; // 0x1C0
		private MonoElementReaction _elementReaction; // 0x1C8
		private UnityAction allCallBack; // 0x1D0
	
		// Properties
		public string entityName { /* [XID] */ /* 0x00000001899D8720-0x00000001899D8740 */ set {} } // 0x0000000184902090-0x0000000184902160
		public string onlineID { /* [XID] */ /* 0x00000001899DFE10-0x00000001899DFE30 */ set {} } // 0x0000000184902160-0x0000000184902230
		public Transform owner { /* [XID] */ /* 0x00000001899E7840-0x00000001899E7860 */ get => default; /* [XID] */ /* 0x00000001899EEDB0-0x00000001899EEDD0 */ set {} } // 0x0000000184901E90-0x0000000184901F30 0x0000000184902230-0x00000001849022E0
		public RectTransform generalMarkContainer { /* [XID] */ /* 0x00000001899FDBF0-0x00000001899FDC10 */ get => default; } // 0x0000000184901DF0-0x0000000184901E90 
		public RectTransform combatBoardContainer { /* [XID] */ /* 0x0000000189A055D0-0x0000000189A055F0 */ get => default; } // 0x0000000184901C00-0x0000000184901CA0 
		public RectTransform elementReactionContainer { /* [XID] */ /* 0x0000000189A0C8F0-0x0000000189A0C910 */ get => default; } // 0x0000000184901CA0-0x0000000184901D40 
		public MonoCombatBillboard combatBillboard { /* [XID] */ /* 0x0000000189A37920-0x0000000189A37940 */ get => default; } // 0x0000000184901B50-0x0000000184901C00 
		public bool showSpeechBubble { /* [XID] */ /* 0x0000000189A3F050-0x0000000189A3F070 */ set {} } // 0x00000001849024A0-0x0000000184902580
		public MonoSpeechBubble speechBubble { /* [XID] */ /* 0x0000000189829CD0-0x0000000189829CF0 */ get => default; } // 0x0000000184901FE0-0x0000000184902090 
		public bool showProgress { /* [XID] */ /* 0x0000000189A5D010-0x0000000189A5D030 */ set {} } // 0x00000001849022E0-0x00000001849023C0
		public MonoProgressBillboard Progress { /* [XID] */ /* 0x0000000189A73840-0x0000000189A73860 */ get => default; } // 0x0000000184901AA0-0x0000000184901B50 
		public MonoArrowPointRecon reconBoard { /* [XID] */ /* 0x0000000189A7B380-0x0000000189A7B3A0 */ get => default; } // 0x0000000184901F30-0x0000000184901FE0 
		public bool showReconBoard { /* [XID] */ /* 0x0000000189A91C50-0x0000000189A91C70 */ set {} } // 0x00000001849023C0-0x00000001849024A0
		public MonoElementReaction elementReaction { /* [XID] */ /* 0x0000000189A99720-0x0000000189A99740 */ get => default; } // 0x0000000184901D40-0x0000000184901DF0 
	
		// Constructors
		public MonoBillboard() {} // 0x0000000184901670-0x0000000184901AA0
	
		// Methods
		// [XID] // 0x00000001899F6670-0x00000001899F6690
		public void SetHPRatio(float ratio, bool init = false /* Metadata: 0x00B0FCA2 */) {} // 0x00000001849014F0-0x0000000184901670
		// [IDTag] // 0x0000000189A14260-0x0000000189A142A0
		// [XID] // 0x0000000189A14260-0x0000000189A142A0
		public void CreateCombatBillboard(CombatBillboardSize size, UnityAction initCallBack) {} // 0x00000001849003F0-0x00000001849004D0
		// [XID] // 0x0000000189A1E460-0x0000000189A1E480
		private void LoadInstanceCallBack(Transform billBoardTransform) {} // 0x00000001849013E0-0x00000001849014F0
		// [IDTag] // 0x0000000189A25B20-0x0000000189A25B60
		// [XID] // 0x0000000189A25B20-0x0000000189A25B60
		private void CreateCombatBillboard(int indexSize) {} // 0x0000000184901100-0x00000001849012F0
		// [XID] // 0x0000000189A2FED0-0x0000000189A2FEF0
		public void DestroyCombatBillboard() {} // 0x0000000184900C20-0x0000000184900D30
		// [XID] // 0x00000001896CE820-0x00000001896CE840
		public void CreateSpeechBubble(UnityAction callback) {} // 0x0000000184900A40-0x0000000184900C20
		// [XID] // 0x000000018974D230-0x000000018974D250
		public void DestroySpeechBubble() {} // 0x0000000184901030-0x0000000184901100
		// [XID] // 0x0000000189A648B0-0x0000000189A648D0
		public void CreateProgress(string prefabPluginName, UnityAction callback) {} // 0x0000000184900680-0x0000000184900870
		// [XID] // 0x0000000189A6C0D0-0x0000000189A6C0F0
		public void DestroyProgress() {} // 0x0000000184900E50-0x0000000184900F20
		// [XID] // 0x0000000189A82A40-0x0000000189A82A60
		public void CreateReconBoard(UnityAction<RectTransform> callback) {} // 0x0000000184900870-0x0000000184900A40
		// [XID] // 0x0000000189A8A450-0x0000000189A8A470
		public void DestroyReconBoard() {} // 0x0000000184900F20-0x0000000184901030
		// [XID] // 0x0000000189AA0770-0x0000000189AA0790
		public void CreateElementReaction(UnityAction callback) {} // 0x00000001849004D0-0x0000000184900680
		// [XID] // 0x0000000189AA7D70-0x0000000189AA7D90
		private void OnElementReactionLoaded(RectTransform trans) {} // 0x00000001849012F0-0x00000001849013E0
		// [XID] // 0x0000000189AAF860-0x0000000189AAF880
		public void DestroyElementReaction() {} // 0x0000000184900D30-0x0000000184900E50
	}
}
