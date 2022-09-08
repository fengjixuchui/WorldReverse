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
using UnityEngine.EventSystems;
using UnityEngine.UI;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

namespace MoleMole
{
	// [RequireComponent] // 0x00000001896DD6E0-0x00000001896DD730
	public class MonoGridScroller : MonoBehaviour, IEndDragHandler, IBeginDragHandler // TypeDefIndex: 30794
	{
		// Fields
		public Transform itemPrefab; // 0x18
		public RectTransform grid; // 0x20
		public Movement moveType; // 0x28
		public MonoScrollBarAutoHide scrollBarAutoHide; // 0x30
		public MonoScrollBar scrollBar; // 0x38
		public string scrollAudioEventName; // 0x40
		public float scrollAudioTriggerVelocity; // 0x48
		public bool stretchCellSize; // 0x4C
		public bool centerContent; // 0x4D
		public bool autoPivot; // 0x4E
		[SerializeField] // 0x00000001896E9500-0x00000001896E9550
		// [Tooltip] // 0x00000001896E9500-0x00000001896E9550
		private bool _fillGrid; // 0x4F
		[SerializeField] // 0x00000001896F5170-0x00000001896F51B0
		// [Tooltip] // 0x00000001896F5170-0x00000001896F51B0
		private bool _perfectAligned; // 0x50
		[SerializeField] // 0x0000000189701000-0x0000000189701050
		// [Tooltip] // 0x0000000189701000-0x0000000189701050
		private bool _itemIsToggle; // 0x51
		[SerializeField] // 0x000000018970D0E0-0x000000018970D120
		// [Tooltip] // 0x000000018970D0E0-0x000000018970D120
		private bool _useWidthAndHeightDirectlyWhenSetIgnorelayout; // 0x52
		[SerializeField] // 0x0000000189718FA0-0x0000000189718FF0
		// [Tooltip] // 0x0000000189718FA0-0x0000000189718FF0
		private bool _noHighlightOnInit; // 0x53
		[HideInInspector] // 0x0000000189B8A170-0x0000000189B8A180
		public bool isGridEnable; // 0x54
		protected HashSet<int> _transIndexSet; // 0x58
		private HashSet<int> _showIndexSet; // 0x60
		protected Dictionary<int, RectTransform> _transDict; // 0x68
		protected OnChange _wrapOnChange; // 0x70
		private OnChange _realOnChange; // 0x78
		private OnSelectorChange _selectorChange; // 0x80
		private OnSelectorChange _selectorChangeForLast; // 0x88
		private OnValueChange _valueChangeCallback; // 0x90
		private MonoScrollerFadeManager _fadeManager; // 0x98
		protected bool _noHighlightOnInitChecker; // 0xA0
		protected int _itemCount; // 0xA4
		protected int _transCount; // 0xA8
		protected int _col; // 0xAC
		protected int _row; // 0xB0
		protected Rect _scrollerRect; // 0xB4
		private Vector2 _cellSize; // 0xC4
		protected Vector2 _spacing; // 0xCC
		protected ScrollRect _scroller; // 0xD8
		protected GridLayoutGroup _layout; // 0xE0
		private Vector2 _padding; // 0xE8
		private float _bottom; // 0xF0
		private float _right; // 0xF4
		protected bool _loadAll; // 0xF8
		private bool _isDragging; // 0xF9
		private bool _isTriggeredDragSound; // 0xFA
		private uint _scrollAudioEvent; // 0xFC
		protected bool _initialized; // 0x100
		private const int SURPLUS_COUNT = 2; // Metadata: 0x00B11590
		protected bool _focusOnChildUIModule; // 0x101
		protected bool _transferNavigateCmdToParent; // 0x102
		protected MonoJoypadGridScrollerHandler _gridHandler; // 0x108
		private Vector2 initTransformVecDefault; // 0x118
		private readonly Vector3[] _tempCorners; // 0x120
		public float scrollSpeed; // 0x128
		private bool _isPlaying; // 0x12C
		private float _deltaRatio; // 0x130
		private float _scrollDirection; // 0x134
		public bool optLoadVisibleItems; // 0x138
		public bool optEnableAsyncLoadItems; // 0x139
		// [Header] // 0x0000000189741530-0x00000001897415A0
		[SerializeField] // 0x0000000189741530-0x00000001897415A0
		// [Tooltip] // 0x0000000189741530-0x00000001897415A0
		private bool _invokeOnClickOnSelect; // 0x13B
		[SerializeField] // 0x0000000189751850-0x0000000189751890
		// [Tooltip] // 0x0000000189751850-0x0000000189751890
		private bool _triggerHighlightOnSelect; // 0x13C
		[SerializeField] // 0x000000018975D6C0-0x000000018975D700
		// [Tooltip] // 0x000000018975D6C0-0x000000018975D700
		private bool _triggerDisabledOnSelect; // 0x13D
		[SerializeField] // 0x00000001897697F0-0x0000000189769840
		// [Tooltip] // 0x00000001897697F0-0x0000000189769840
		private bool _invokeOnClickOnConfirm; // 0x13E
		[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
		private ContextEventType _confirmItemEvent; // 0x140
		[SerializeField] // 0x000000018977CCF0-0x000000018977CD30
		// [Tooltip] // 0x000000018977CCF0-0x000000018977CD30
		private bool _triggerSelectedOnSelect; // 0x144
		private int _currIndex; // 0x148
		private Action<RectTransform, bool> _onSelectChange; // 0x150
		private bool _keepDefaultChangeAction; // 0x158
	
		// Properties
		protected OnChange _onChange { /* [XID] */ /* 0x0000000189788D90-0x0000000189788DB0 */ get => default; /* [XID] */ /* 0x0000000189790340-0x0000000189790360 */ set {} } // 0x000000018407AD20-0x000000018407ADC0 0x0000000184079580-0x0000000184079660
		public OnValueChange valueChangeCallback { /* [XID] */ /* 0x0000000189797CB0-0x0000000189797CD0 */ set {} } // 0x000000018407FA60-0x000000018407FB10
		public Vector2 ItemSize { /* [XID] */ /* 0x000000018979F990-0x000000018979F9B0 */ get => default; } // 0x000000018407F4C0-0x000000018407F5C0 
		public int itemCount { /* [XID] */ /* 0x00000001897A6F90-0x00000001897A6FB0 */ get => default; } // 0x000000018407F670-0x000000018407F710 
		public BaseContext context { /* [XID] */ /* 0x00000001897BE630-0x00000001897BE670 */ private get; /* [XID] */ /* 0x00000001897C8DC0-0x00000001897C8E00 */ set; } // 0x000000018407B770-0x000000018407B7D0 0x000000018407F820-0x000000018407F890
		public bool isPlayingAnimScroll { /* [XID] */ /* 0x00000001898607C0-0x00000001898607E0 */ get => default; } // 0x000000018407F5C0-0x000000018407F670 
		public bool playScrollViewAnimationOnEnable { /* [XID] */ /* 0x0000000189993780-0x00000001899937C0 */ get; /* [XID] */ /* 0x000000018999E0B0-0x000000018999E0F0 */ set; } // 0x000000018407F710-0x000000018407F770 0x000000018407F940-0x000000018407F9B0
		public bool triggerHighlightOnSelect { /* [XID] */ /* 0x00000001899B76C0-0x00000001899B76E0 */ get => default; /* [XID] */ /* 0x00000001899BF0A0-0x00000001899BF0C0 */ set {} } // 0x000000018407F770-0x000000018407F820 0x000000018407F9B0-0x000000018407FA60
		public bool invokeOnClickOnConfirm { /* [XID] */ /* 0x00000001899C6A40-0x00000001899C6A60 */ set {} } // 0x000000018407F890-0x000000018407F940
	
		// Nested types
		public enum Movement // TypeDefIndex: 30795
		{
			Horizontal = 0,
			Vertical = 1,
			None = 2
		}
	
		public delegate void OnChange(Transform trans, int index); // TypeDefIndex: 30796; 0x0000000184065B10-0x0000000184065DC0
	
		public delegate void OnSelectorChange(Transform trans, int index); // TypeDefIndex: 30797; 0x00000001840652C0-0x0000000184065570
	
		public delegate void OnValueChange(Vector2 normalizedPosition); // TypeDefIndex: 30798; 0x0000000184065700-0x0000000184065880
	
		// Constructors
		public MonoGridScroller() {} // 0x000000018407F280-0x000000018407F4C0
	
		// Methods
		// [XID] // 0x00000001897AE8D0-0x00000001897AE8F0
		public void SetFocusOnChildUIModule(bool focus, bool transferNavigateCmd) {} // 0x000000018407E8A0-0x000000018407E970
		// [XID] // 0x00000001897B67F0-0x00000001897B6810
		public void SetGridHandler(MonoJoypadGridScrollerHandler gridHandler) {} // 0x000000018407E970-0x000000018407EA20
		// [XID] // 0x00000001897D3270-0x00000001897D3290
		public virtual void Init(OnChange onChange, int itemCount, Vector2? normalizedPosition = default, bool loadAll = false /* Metadata: 0x00B11586 */, bool forceInit = false /* Metadata: 0x00B11587 */, bool scrollToBeginOnInit = true /* Metadata: 0x00B11588 */) {} // 0x00000001840797B0-0x0000000184079CD0
		// [XID] // 0x00000001897DACF0-0x00000001897DAD10
		private bool NeedForceInit() => default; // 0x0000000184076700-0x0000000184076890
		// [XID] // 0x00000001897E2400-0x00000001897E2420
		public void ClearOnChange() {} // 0x0000000184075D40-0x0000000184075DE0
		// [XID] // 0x00000001897E9B70-0x00000001897E9B90
		public void RefreshCurrent() {} // 0x000000018407D4A0-0x000000018407D6E0
		// [XID] // 0x00000001897F1830-0x00000001897F1850
		public void RefreshCurrentByIndex(int index) {} // 0x000000018407D300-0x000000018407D4A0
		// [XID] // 0x00000001897F8F60-0x00000001897F8F80
		public Vector2 GetNormalizedPosition() => default; // 0x0000000184078640-0x0000000184078710
		// [XID] // 0x0000000189800570-0x0000000189800590
		public void SetNormalizedPosition(Vector2 normalizedPosition) {} // 0x000000018407EAF0-0x000000018407EBB0
		// [XID] // 0x0000000189807BF0-0x0000000189807C10
		public void ScrollToPrevPage() {} // 0x000000018407E360-0x000000018407E430
		// [XID] // 0x000000018980F4B0-0x000000018980F4D0
		public void ScrollToNextPage() {} // 0x000000018407E030-0x000000018407E100
		// [XID] // 0x0000000189816B60-0x0000000189816B80
		public void ScrollToPreItem() {} // 0x000000018407E1D0-0x000000018407E290
		// [XID] // 0x000000018981E410-0x000000018981E430
		public void ScrollToNextItem() {} // 0x000000018407DEA0-0x000000018407DF60
		// [XID] // 0x0000000189825880-0x00000001898258A0
		public void ScrollToBegin() {} // 0x000000018407DC30-0x000000018407DD00
		// [XID] // 0x000000018982D080-0x000000018982D0A0
		public void ScrollToEnd() {} // 0x000000018407DD00-0x000000018407DDD0
		// [XID] // 0x00000001898347E0-0x0000000189834800
		public void CenterItemByIndex(int index) {} // 0x0000000184075070-0x0000000184075330
		// [XID] // 0x000000018983BE30-0x000000018983BE50
		public void ScrollMinimumToShowItem(int index) {} // 0x000000018407D820-0x000000018407DC30
		// [XID] // 0x0000000189843480-0x00000001898434A0
		public void ScrollToShowItemHorizontal(int index) {} // 0x000000018407E430-0x000000018407E690
		// [XID] // 0x000000018984A9A0-0x000000018984A9C0
		public int GetLastRealShowIndexHorizontal() => default; // 0x0000000184078200-0x0000000184078590
		// [XID] // 0x0000000189851DA0-0x0000000189851DC0
		public int GetFirstRealShowIndexHorizontal() => default; // 0x00000001840772A0-0x0000000184077620
		// [XID] // 0x0000000189859640-0x0000000189859660
		private void DoScroll(float delta) {} // 0x000000018407A790-0x000000018407AA30
		// [XID] // 0x0000000189867E90-0x0000000189867EB0
		private void DoScrollWithAnimation(float delta) {} // 0x000000018407B3B0-0x000000018407B770
		// [XID] // 0x000000018986F3F0-0x000000018986F410
		public void ScrollToNextPageWithAnimation() {} // 0x000000018407DF60-0x000000018407E030
		// [XID] // 0x0000000189876A20-0x0000000189876A40
		public void ScrollToPrevPageWithAnimation() {} // 0x000000018407E290-0x000000018407E360
		// [XID] // 0x000000018987E540-0x000000018987E560
		public void ScrollToNextItemWithAnimation() {} // 0x000000018407DDD0-0x000000018407DEA0
		// [XID] // 0x00000001898858F0-0x0000000189885910
		public void ScrollToPreItemWithAnimation() {} // 0x000000018407E100-0x000000018407E1D0
		// [XID] // 0x000000018988CBE0-0x000000018988CC00
		private void Update() {} // 0x000000018407EFC0-0x000000018407F280
		// [XID] // 0x00000001898942F0-0x0000000189894310
		public void AddChildren(int addCount) {} // 0x00000001840742E0-0x0000000184074400
		// [XID] // 0x000000018989B860-0x000000018989B880
		public void RemoveChildren(int removeCount) {} // 0x000000018407D6E0-0x000000018407D820
		// [XID] // 0x00000001898A2D50-0x00000001898A2D70
		public Transform GetItemTransByIndex(int index) => default; // 0x0000000184078110-0x0000000184078200
		// [XID] // 0x00000001898AA270-0x00000001898AA290
		public int GetMaxItemCountWithoutScroll() => default; // 0x0000000184078590-0x0000000184078640
		// [XID] // 0x00000001898B1C50-0x00000001898B1C70
		public int GetFixSideItemCount() => default; // 0x0000000184077620-0x00000001840776D0
		// [XID] // 0x00000001898B9870-0x00000001898B9890
		private int PerfectShowItemCount() => default; // 0x000000018407BEA0-0x000000018407BF70
		// [XID] // 0x00000001898C0CB0-0x00000001898C0CD0
		public int GetPerfectShowItemCount() => default; // 0x0000000184078710-0x00000001840788F0
		// [XID] // 0x00000001898C85B0-0x00000001898C85D0
		public void LeftMoveItem(int moveItemCount) {} // 0x000000018407AF30-0x000000018407B170
		// [XID] // 0x00000001898CFF80-0x00000001898CFFA0
		protected void InitScroller() {} // 0x000000018407CFE0-0x000000018407D1B0
		// [XID] // 0x00000001898D7590-0x00000001898D75B0
		private Rect GetScrollRect() => default; // 0x0000000184074400-0x00000001840745D0
		// [XID] // 0x00000001898DF2A0-0x00000001898DF2C0
		protected void InitGrid() {} // 0x00000001840740B0-0x00000001840742E0
		// [XID] // 0x00000001898E6C60-0x00000001898E6C80
		private void InitLayout() {} // 0x00000001840745D0-0x0000000184075070
		// [XID] // 0x00000001898EE390-0x00000001898EE3B0
		private void InitChildren() {} // 0x0000000184076C90-0x0000000184076D70
		// [XID] // 0x00000001898F5C00-0x00000001898F5C20
		protected void AddNewChildByIndex(int index) {} // 0x0000000184079240-0x0000000184079430
		// [XID] // 0x00000001898FD3E0-0x00000001898FD400
		protected void RemoveChildByIndex(int i) {} // 0x00000001840764D0-0x0000000184076700
		// [XID] // 0x0000000189904C80-0x0000000189904CA0
		protected int CalculateTransCount() => default; // 0x0000000184076200-0x00000001840762D0
		// [XID] // 0x000000018990C4C0-0x000000018990C4E0
		private void InitChild(RectTransform rectTrans, int index) {} // 0x000000018407ADC0-0x000000018407AF30
		// [XID] // 0x0000000189913DB0-0x0000000189913DD0
		protected void InitTransform(Vector2? normalizedPosition = default) {} // 0x0000000184078AF0-0x0000000184078E20
		// [XID] // 0x000000018991B720-0x000000018991B740
		protected void InitScorllBar() {} // 0x000000018407CBE0-0x000000018407CE30
		// [XID] // 0x0000000189922D00-0x0000000189922D20
		protected void Clear() {} // 0x0000000184076B50-0x0000000184076C90
		// [XID] // 0x000000018992A5D0-0x000000018992A5F0
		public void OnValueChanged(Vector2 normalizedPosition) {} // 0x000000018407C810-0x000000018407CA10
		// [XID] // 0x0000000189931BA0-0x0000000189931BC0
		protected void RefreshIndexSet() {} // 0x0000000184076080-0x0000000184076200
		// [XID] // 0x0000000189939600-0x0000000189939620
		public void OnEndDrag(PointerEventData eventData) {} // 0x000000018407C570-0x000000018407C6F0
		// [XID] // 0x00000001899408D0-0x00000001899408F0
		private void SwapIndex(int startIndex) {} // 0x000000018407BF70-0x000000018407C3D0
		// [XID] // 0x0000000189948150-0x0000000189948170
		private void ChangeToIndex(int from, int to) {} // 0x0000000184073D00-0x00000001840740B0
		// [XID] // 0x000000018994F8D0-0x000000018994F8F0
		private Vector2 IndexToPosition(int index, Vector2 pivot) => default; // 0x000000018407B170-0x000000018407B3B0
		// [XID] // 0x0000000189956E70-0x0000000189956E90
		public Dictionary<int, RectTransform> GetItemDict() => default; // 0x0000000184078070-0x0000000184078110
		// [XID] // 0x000000018995E9E0-0x000000018995EA00
		public bool CheckIndexShow(int index) => default; // 0x00000001840756C0-0x0000000184075790
		// [XID] // 0x0000000189966100-0x0000000189966120
		private void ProcessSlideAudio() {} // 0x000000018407CE30-0x000000018407CFE0
		// [XID] // 0x000000018996D5E0-0x000000018996D600
		private void WrapOnChange(Transform trans, int index) {} // 0x0000000184079430-0x0000000184079580
		// [XID] // 0x0000000189975160-0x0000000189975180
		private RectTransform GetOrCreateTrans(int index) => default; // 0x000000018407CA10-0x000000018407CBE0
		// [XID] // 0x000000018997C320-0x000000018997C340
		private bool IsChildVisible(int index) => default; // 0x000000018407A500-0x000000018407A790
		// [XID] // 0x0000000189984040-0x0000000189984060
		private void LoadVisibleItems() {} // 0x0000000184076890-0x0000000184076A80
		// [XID] // 0x000000018998BBD0-0x000000018998BBF0
		public int GetGridRealChildCount() => default; // 0x00000001840776D0-0x0000000184078070
		// [XID] // 0x00000001899A8A30-0x00000001899A8A50
		public void OnEnable() {} // 0x000000018407C480-0x000000018407C570
		// [XID] // 0x00000001899B0350-0x00000001899B0370
		public void PlayScrollViewAnimation() {} // 0x000000018407D1B0-0x000000018407D300
		// [XID] // 0x00000001899CDFE0-0x00000001899CE000
		public void InitForJoystick() {} // 0x0000000184079660-0x00000001840797B0
		// [XID] // 0x00000001899D5740-0x00000001899D5760
		public int GetCurIndex() => default; // 0x0000000184077150-0x00000001840771F0
		// [XID] // 0x00000001899DCAD0-0x00000001899DCAF0
		public Transform GetCurTransform() => default; // 0x00000001840771F0-0x00000001840772A0
		// [XID] // 0x00000001899E4750-0x00000001899E4770
		public void SetCurIndexWithRefresh(int index, bool force = false /* Metadata: 0x00B11589 */) {} // 0x000000018407E690-0x000000018407E7F0
		// [XID] // 0x00000001899EBA60-0x00000001899EBA80
		public void SetCurIndex(int index) {} // 0x000000018407E7F0-0x000000018407E8A0
		// [XID] // 0x00000001899F3530-0x00000001899F3550
		public void SetSelectorAction(OnSelectorChange change) {} // 0x000000018407EC60-0x000000018407ED10
		// [XID] // 0x00000001899FAEF0-0x00000001899FAF10
		public void SetSelectorActionForLast(OnSelectorChange change) {} // 0x000000018407EBB0-0x000000018407EC60
		// [XID] // 0x0000000189A02140-0x0000000189A02160
		public bool HandleInputActionEventType(ContextEventType type, bool skipInactive, out JoypadControllerActionType action) {
			action = default;
			return default;
		} // 0x0000000184079040-0x0000000184079240
		// [XID] // 0x0000000189A09910-0x0000000189A09930
		public bool HandleContextEvent(ContextEventType contextEvent) => default; // 0x0000000184078F30-0x0000000184079040
		// [XID] // 0x0000000189A11050-0x0000000189A11070
		public bool HandleContextEventAndPlaySound(ContextEventType contextEvent, uint audioId) => default; // 0x0000000184078E20-0x0000000184078F30
		// [XID] // 0x0000000189A18400-0x0000000189A18420
		private void HandlerJoystickEvent(ContextEventType type, bool skipInactive) {} // 0x00000001840762D0-0x00000001840763B0
		// [XID] // 0x0000000189A1FB10-0x0000000189A1FB30
		public void ChangeForJoystick(ContextEventType contextEventType, bool forceMove = false /* Metadata: 0x00B1158A */) {} // 0x0000000184075500-0x00000001840756C0
		// [XID] // 0x0000000189A26E90-0x0000000189A26EB0
		public int GetRealRow() => default; // 0x00000001840789F0-0x0000000184078AF0
		// [XID] // 0x0000000189A2E6D0-0x0000000189A2E6F0
		public int GetRealCol() => default; // 0x00000001840788F0-0x00000001840789F0
		// [XID] // 0x0000000189A36000-0x0000000189A36020
		public bool IsAtTop() => default; // 0x000000018407A160-0x000000018407A240
		// [XID] // 0x0000000189A3D600-0x0000000189A3D620
		public bool IsAtBottom() => default; // 0x0000000184079F90-0x000000018407A080
		// [XID] // 0x0000000189A44CD0-0x0000000189A44CF0
		public bool IsAtFront() => default; // 0x000000018407A080-0x000000018407A160
		// [XID] // 0x0000000189A4C540-0x0000000189A4C560
		public bool IsAtBack() => default; // 0x0000000184079EA0-0x0000000184079F90
		// [XID] // 0x0000000189A53CE0-0x0000000189A53D00
		public void ChangeForJoystickSkipInactive(ContextEventType contextEventType) {} // 0x0000000184075330-0x0000000184075500
		// [XID] // 0x0000000189A5B6F0-0x0000000189A5B710
		public bool IsItemInteractable(int index) => default; // 0x000000018407A240-0x000000018407A390
		// [IDTag] // 0x0000000189A62D60-0x0000000189A62DA0
		// [XID] // 0x0000000189A62D60-0x0000000189A62DA0
		public void OnRefreshForJoyStick(bool forceMove = false /* Metadata: 0x00B1158B */) {} // 0x000000018407C6F0-0x000000018407C810
		// [XID] // 0x0000000189A6D570-0x0000000189A6D590
		public void SetJoypodSelectStateChangeCallBack(Action<RectTransform, bool> callBack, bool keepDefaultChangeAction = false /* Metadata: 0x00B1158C */) {} // 0x000000018407EA20-0x000000018407EAF0
		// [XID] // 0x0000000189A74CF0-0x0000000189A74D10
		public void ClearItemJoystickSelectState() {} // 0x0000000184075C50-0x0000000184075D40
		// [XID] // 0x0000000189A7C940-0x0000000189A7C960
		private void RefreshItemJoyStickState(RectTransform item, bool select) {} // 0x0000000184076D70-0x00000001840770B0
		// [XID] // 0x0000000189A84240-0x0000000189A84260
		private Selectable GetButtonByItem(RectTransform item) => default; // 0x0000000184076A80-0x0000000184076B50
		private T GetButtonByItem<T>(RectTransform item)
			where T : Selectable => default;
		// [IDTag] // 0x0000000189A8BB30-0x0000000189A8BB70
		// [XID] // 0x0000000189A8BB30-0x0000000189A8BB70
		private void OnRefreshForJoyStick(int currIndex, int? prevIndex, bool forceMove = false /* Metadata: 0x00B1158D */) {} // 0x000000018407B7D0-0x000000018407BEA0
		// [XID] // 0x0000000189A96170-0x0000000189A96190
		public ContextEventType GetClickEvent() => default; // 0x00000001840770B0-0x0000000184077150
		// [XID] // 0x0000000189A9D680-0x0000000189A9D6A0
		public void ClickIndexItem(int currIndex) {} // 0x0000000184075EE0-0x0000000184076080
		// [IDTag] // 0x0000000189AA4EC0-0x0000000189AA4F00
		// [XID] // 0x0000000189AA4EC0-0x0000000189AA4F00
		public void UpdateFocusTarget(int index, bool autoClear = true /* Metadata: 0x00B1158E */) {} // 0x000000018407EE50-0x000000018407EFC0
		// [IDTag] // 0x0000000189AAF720-0x0000000189AAF760
		// [XID] // 0x0000000189AAF720-0x0000000189AAF760
		public void UpdateFocusTarget(RectTransform trans, bool autoClear = true /* Metadata: 0x00B1158F */) {} // 0x000000018407ED10-0x000000018407EE50
		// [XID] // 0x0000000189ABA290-0x0000000189ABA2B0
		public void EnableAutoFocus(bool enableFocus) {} // 0x00000001840763B0-0x00000001840764D0
		// [XID] // 0x0000000189AC1BC0-0x0000000189AC1BE0
		public void ClearCurTarget() {} // 0x0000000184075B00-0x0000000184075C50
		// [XID] // 0x0000000189AC9150-0x0000000189AC9170
		public void ClearSelector() {} // 0x0000000184075DE0-0x0000000184075EE0
		// [XID] // 0x0000000189AD0BA0-0x0000000189AD0BC0
		public void ClearChildModuleFocus() {} // 0x0000000184075790-0x0000000184075A20
		// [XID] // 0x0000000189AD87E0-0x0000000189AD8800
		private void OnChangeSelector(RectTransform from, int fromIndex, RectTransform to, int toIndex) {} // 0x000000018407ABA0-0x000000018407AD20
		// [XID] // 0x0000000189AE0400-0x0000000189AE0420
		public bool InvokeOnClickOnCurrSelect() => default; // 0x0000000184079CD0-0x0000000184079EA0
		// [XID] // 0x0000000189AE79B0-0x0000000189AE79D0
		public void ClearCurForJoystick() {} // 0x0000000184075A20-0x0000000184075B00
		// [XID] // 0x0000000189AEF6B0-0x0000000189AEF6D0
		public void OnBeginDrag(PointerEventData eventData) {} // 0x000000018407C3D0-0x000000018407C480
		// [XID] // 0x0000000189AF6BD0-0x0000000189AF6BF0
		private float GetScrollerWidth() => default; // 0x000000018407AA30-0x000000018407ABA0
		// [XID] // 0x0000000189AFE100-0x0000000189AFE120
		private float GetScrollerHeight() => default; // 0x000000018407A390-0x000000018407A500
	}
}
