/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using IFix.Core;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	public class MonoAdsorbEffect2DController : MonoBehaviour // TypeDefIndex: 30606
	{
		// Fields
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private bool _playOnStart; // 0x18
		private bool _isPlaying; // 0x19
		private int _finishCount; // 0x1C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private MoveType _moveTypeEnum; // 0x20
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ItemCreateType _moveItemCreateTypeEnum; // 0x24
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ItemPlayEffectType _moveItemPlayEffectTypeEnum; // 0x28
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<Transform> _cachedMoveItems; // 0x30
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ItemCreateType _endItemCreateTypeEnum; // 0x38
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ItemPlayEffectType _endItemPlayEffectTypeEnum; // 0x3C
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private List<Transform> _cachedEndItems; // 0x40
		private RectTransform _uiPosTransform; // 0x48
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _startPosionAreaComponent; // 0x50
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Transform _endPosionAreaComponent; // 0x58
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector2 _startAngelRange; // 0x60
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector2 _startSpeedRange; // 0x68
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector2 _duringTotalTimeRange; // 0x70
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private Vector2 _startIntervalTimeRange; // 0x78
		private AdsorbEffectDataSourceInterface _cachedMonoDataSource; // 0x80
		private AdsorbEffectDataSourceInterface _customDataSource; // 0x88
		private List<int> _randomIndexList; // 0x90
		private Stack<Transform> _availableMoveItems; // 0x98
		private Stack<Transform> _availableEndItems; // 0xA0
		private List<Coroutine> _coroutines; // 0xA8
		private Action _onFinish; // 0xB0
		private Action _onSuspend; // 0xB8
	
		// Properties
		private AdsorbEffectDataSourceInterface DataSource { /* [XID] */ /* 0x00000001898E5050-0x00000001898E5070 */ get => default; } // 0x00000001852EF750-0x00000001852EF810 
	
		// Nested types
		public enum ItemCreateType // TypeDefIndex: 30607
		{
			Keep = 0,
			AutoCreate = 1
		}
	
		public enum ItemPlayEffectType // TypeDefIndex: 30608
		{
			KeepSequence = 0,
			Recycle = 1
		}
	
		public enum MoveType // TypeDefIndex: 30609
		{
			PointToPoint = 0,
			RectToRectIn2D = 1
		}
	
		// Constructors
		public MonoAdsorbEffect2DController() {} // 0x00000001852F0BC0-0x00000001852F0FB0
	
		// Methods
		// [XID] // 0x00000001898D5B50-0x00000001898D5B70
		public Transform GetCachedMoveItem(int index) => default; // 0x00000001852EF810-0x00000001852EF900
		// [XID] // 0x00000001898DD820-0x00000001898DD840
		public Transform GetEndItem(int index) => default; // 0x00000001852EF900-0x00000001852EF9F0
		// [XID] // 0x00000001898EC8C0-0x00000001898EC8E0
		private void Awake() {} // 0x00000001852EED60-0x00000001852EF370
		// [XID] // 0x00000001898F42D0-0x00000001898F42F0
		private void Start() {} // 0x00000001852F0850-0x00000001852F0910
		// [XID] // 0x00000001898FBAA0-0x00000001898FBAC0
		private void OnDisable() {} // 0x00000001852F0410-0x00000001852F04B0
		// [XID] // 0x0000000189903470-0x0000000189903490
		public bool IsEffectPlaying() => default; // 0x00000001852EFBF0-0x00000001852EFC90
		// [XID] // 0x000000018990A9C0-0x000000018990A9E0
		public void StopEffect() {} // 0x00000001852F0910-0x00000001852F0BC0
		// [XID] // 0x0000000189912650-0x0000000189912670
		public bool PlayEffect(Action onFinish = null, Action onSuspend = null) => default; // 0x00000001852F04B0-0x00000001852F0640
		// [XID] // 0x0000000189919F20-0x0000000189919F40
		public void SetCustomDataSource(AdsorbEffectDataSourceInterface dataSource) {} // 0x00000001852F0640-0x00000001852F06F0
		// [XID] // 0x0000000189921740-0x0000000189921760
		public void SetTotalMoveCount(int itemCount) {} // 0x00000001852F06F0-0x00000001852F0850
		// [XID] // 0x0000000189928E40-0x0000000189928E60
		private void ResetAllEffectItems() {} // 0x00000001852EF450-0x00000001852EF630
		// [XID] // 0x00000001899303D0-0x00000001899303F0
		private AdsorbEffectItemInterface ModifyEffectItemState(Transform itemTransform, int index, int state) => default; // 0x00000001852EEBD0-0x00000001852EED60
		// [XID] // 0x00000001899378A0-0x00000001899378C0
		private void AddAvailableMoveItem(Transform item) {} // 0x00000001852F0240-0x00000001852F0310
		// [XID] // 0x000000018993F390-0x000000018993F3B0
		private Transform FindAvailableMoveItem() => default; // 0x00000001852EF370-0x00000001852EF450
		// [XID] // 0x0000000189946980-0x00000001899469A0
		private void AddAvailableEndItem(Transform item) {} // 0x00000001852EFC90-0x00000001852EFD60
		// [XID] // 0x000000018994E040-0x000000018994E060
		private Transform FindAvailableEndItem() => default; // 0x00000001852EFF90-0x00000001852F0070
		// [XID] // 0x0000000189955680-0x00000001899556A0
		private bool IsEffectItemAvailable(Transform itemTransform) => default; // 0x00000001852EF630-0x00000001852EF750
		// [XID] // 0x000000018995D1A0-0x000000018995D1C0
		private void ClearCoroutineAndCallbacks() {} // 0x00000001852F0070-0x00000001852F0140
		[DebuggerHidden] // 0x0000000189964800-0x0000000189964840
		// [XID] // 0x0000000189964800-0x0000000189964840
		private IEnumerator PlayCoroutine() => default; // 0x00000001852EFEC0-0x00000001852EFF90
		// [XID] // 0x000000018996EC10-0x000000018996EC30
		private void ShuffleIndexes(int totalCount) {} // 0x00000001852EF9F0-0x00000001852EFBF0
		[DebuggerHidden] // 0x00000001899767F0-0x0000000189976830
		// [XID] // 0x00000001899767F0-0x0000000189976830
		private IEnumerator PlayMoveEffectCoroutine(Transform itemTransform, MonoAdsorbMoveEffect3DComponent moveComponent) => default; // 0x00000001852F0140-0x00000001852F0240
		[DebuggerHidden] // 0x00000001899813B0-0x00000001899813F0
		// [XID] // 0x00000001899813B0-0x00000001899813F0
		private IEnumerator PlayMoveEndEffectCoroutine(Transform itemTransform, MonoAdsorbMoveEffect3DComponent moveComponent) => default; // 0x00000001852F0310-0x00000001852F0410
		[DebuggerHidden] // 0x000000018998BC50-0x000000018998BC90
		// [XID] // 0x000000018998BC50-0x000000018998BC90
		private IEnumerator PlayEndEffectCoroutine(Vector3 endPosition, int i) => default; // 0x00000001852EFD60-0x00000001852EFEC0
	}
}
