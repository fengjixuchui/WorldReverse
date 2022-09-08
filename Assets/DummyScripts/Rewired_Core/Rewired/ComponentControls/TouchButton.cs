/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rewired;
using Rewired.ComponentControls.Data;
using Rewired.Internal;
using Rewired.Utils.Attributes;
using Rewired.Utils.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

// Image 39: Rewired_Core.dll - Assembly: Rewired_Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null - Types 3466-4436

namespace Rewired.ComponentControls
{
	[Serializable]
	[CustomClassObfuscation] // 0x0000000189BC3D10-0x0000000189BC3D50
	[DisallowMultipleComponent] // 0x0000000189BC3D10-0x0000000189BC3D50
	public sealed class TouchButton : TouchInteractable // TypeDefIndex: 3575
	{
		// Fields
		private const float fruQAKvnXDBCklnsQHCaJkENDtS = 20f; // Metadata: 0x00AC404D
		[CustomObfuscation] // 0x0000000189BCE540-0x0000000189BCE5A0
		[SerializeField] // 0x0000000189BCE540-0x0000000189BCE5A0
		// [Tooltip] // 0x0000000189BCE540-0x0000000189BCE5A0
		private CustomControllerElementTargetSetForFloat _targetCustomControllerElement; // 0x110
		[CustomObfuscation] // 0x0000000189BDD420-0x0000000189BDD480
		[SerializeField] // 0x0000000189BDD420-0x0000000189BDD480
		// [Tooltip] // 0x0000000189BDD420-0x0000000189BDD480
		private ButtonType _buttonType; // 0x118
		[CustomObfuscation] // 0x00000001895F1520-0x00000001895F1580
		[SerializeField] // 0x00000001895F1520-0x00000001895F1580
		// [Tooltip] // 0x00000001895F1520-0x00000001895F1580
		private bool _activateOnSwipeIn; // 0x11C
		[CustomObfuscation] // 0x0000000189600420-0x0000000189600480
		[SerializeField] // 0x0000000189600420-0x0000000189600480
		// [Tooltip] // 0x0000000189600420-0x0000000189600480
		private bool _stayActiveOnSwipeOut; // 0x11D
		[CustomObfuscation] // 0x000000018960F580-0x000000018960F5E0
		[SerializeField] // 0x000000018960F580-0x000000018960F5E0
		// [Tooltip] // 0x000000018960F580-0x000000018960F5E0
		private bool _useDigitalAxisSimulation; // 0x11E
		[CustomObfuscation] // 0x000000018961E540-0x000000018961E5C0
		// [FieldRange] // 0x000000018961E540-0x000000018961E5C0
		[SerializeField] // 0x000000018961E540-0x000000018961E5C0
		// [Tooltip] // 0x000000018961E540-0x000000018961E5C0
		private float _digitalAxisGravity; // 0x120
		[CustomObfuscation] // 0x0000000189630510-0x0000000189630590
		// [FieldRange] // 0x0000000189630510-0x0000000189630590
		[SerializeField] // 0x0000000189630510-0x0000000189630590
		// [Tooltip] // 0x0000000189630510-0x0000000189630590
		private float _digitalAxisSensitivity; // 0x124
		[CustomObfuscation] // 0x00000001896423F0-0x0000000189642450
		[SerializeField] // 0x00000001896423F0-0x0000000189642450
		// [Tooltip] // 0x00000001896423F0-0x0000000189642450
		private StandaloneAxis _axis; // 0x128
		[CustomObfuscation] // 0x0000000189651230-0x0000000189651290
		[SerializeField] // 0x0000000189651230-0x0000000189651290
		// [Tooltip] // 0x0000000189651230-0x0000000189651290
		private TouchRegion _touchRegion; // 0x130
		[CustomObfuscation] // 0x0000000189660140-0x00000001896601A0
		[SerializeField] // 0x0000000189660140-0x00000001896601A0
		// [Tooltip] // 0x0000000189660140-0x00000001896601A0
		private bool _useTouchRegionOnly; // 0x138
		[CustomObfuscation] // 0x000000018966F590-0x000000018966F5F0
		[SerializeField] // 0x000000018966F590-0x000000018966F5F0
		// [Tooltip] // 0x000000018966F590-0x000000018966F5F0
		private bool _moveToTouchPosition; // 0x139
		[CustomObfuscation] // 0x000000018967E480-0x000000018967E4E0
		[SerializeField] // 0x000000018967E480-0x000000018967E4E0
		// [Tooltip] // 0x000000018967E480-0x000000018967E4E0
		private bool _returnOnRelease; // 0x13A
		[CustomObfuscation] // 0x000000018968D7C0-0x000000018968D820
		[SerializeField] // 0x000000018968D7C0-0x000000018968D820
		// [Tooltip] // 0x000000018968D7C0-0x000000018968D820
		private bool _followTouchPosition; // 0x13B
		[CustomObfuscation] // 0x000000018969C9E0-0x000000018969CA40
		[SerializeField] // 0x000000018969C9E0-0x000000018969CA40
		// [Tooltip] // 0x000000018969C9E0-0x000000018969CA40
		private bool _animateOnMoveToTouch; // 0x13C
		[CustomObfuscation] // 0x00000001896AB370-0x00000001896AB3F0
		// [Range] // 0x00000001896AB370-0x00000001896AB3F0
		[SerializeField] // 0x00000001896AB370-0x00000001896AB3F0
		// [Tooltip] // 0x00000001896AB370-0x00000001896AB3F0
		private float _moveToTouchSpeed; // 0x140
		[CustomObfuscation] // 0x00000001896BCD00-0x00000001896BCD60
		[SerializeField] // 0x00000001896BCD00-0x00000001896BCD60
		// [Tooltip] // 0x00000001896BCD00-0x00000001896BCD60
		private bool _animateOnReturn; // 0x144
		[CustomObfuscation] // 0x00000001896CB720-0x00000001896CB7A0
		// [Range] // 0x00000001896CB720-0x00000001896CB7A0
		[SerializeField] // 0x00000001896CB720-0x00000001896CB7A0
		// [Tooltip] // 0x00000001896CB720-0x00000001896CB7A0
		private float _returnSpeed; // 0x148
		[CustomObfuscation] // 0x00000001896DD350-0x00000001896DD3B0
		[SerializeField] // 0x00000001896DD350-0x00000001896DD3B0
		// [Tooltip] // 0x00000001896DD350-0x00000001896DD3B0
		private bool _manageRaycasting; // 0x14C
		private float nNEEUtDnZNGztzylwYsGUXILDzX; // 0x150
		private float epmELKqQkigMEBswrOLxBaKJgksu; // 0x154
		private TouchRegion yOoaERsLfwRYibdXndHsenfOaVXe; // 0x158
		private Vector2 AYIaFSyXLVsjxxyIKwNjduqJaEM; // 0x160
		private bool GmmtQmbFnqcHiBbFQapXEeqdMsIP; // 0x168
		private bool BfEabZhMOdfBmuBiTDzXflgDYlzq; // 0x169
		private vYIjyUMfsrLjixlJmTaeYJNvqmn JUQAZmPbLZlOaQZfnawbuDZePwz; // 0x16C
		private int JMoqQTgkIefgMovyFXwlzczIaOU; // 0x170
		private int qkqJpryWPyBJRDHKnavLPnAoLsP; // 0x174
		[NonSerialized]
		private bool jYtFWKZUVrechfzATGCgCETBhJCg; // 0x178
		[NonSerialized]
		private bool GXxxUMYvhnAdzwfrIpAYPjIWpue; // 0x179
		private IEnumerator ujMkhdPMeAqacuGnPYMNkpmJFwqB; // 0x180
		private RXykqpoobZXbeYNAmfMakWSBJalU cVCPUrwTVVqfwiajczZVENUMDXp; // 0x188
		private Action<vYIjyUMfsrLjixlJmTaeYJNvqmn> QfeERTvvsihycVEwQaWsaWlttYqn; // 0x190
		private Action<vYIjyUMfsrLjixlJmTaeYJNvqmn> nglBdOdoufkmXWvKgSGPncWSRcPa; // 0x198
		[CustomObfuscation] // 0x00000001896EA980-0x00000001896EA9E0
		[SerializeField] // 0x00000001896EA980-0x00000001896EA9E0
		// [Tooltip] // 0x00000001896EA980-0x00000001896EA9E0
		private AxisValueChangedEventHandler _onAxisValueChanged; // 0x1A0
		[CustomObfuscation] // 0x00000001896F9440-0x00000001896F94A0
		[SerializeField] // 0x00000001896F9440-0x00000001896F94A0
		// [Tooltip] // 0x00000001896F9440-0x00000001896F94A0
		private ButtonValueChangedEventHandler _onButtonValueChanged; // 0x1A8
		[CustomObfuscation] // 0x0000000189708470-0x00000001897084D0
		[SerializeField] // 0x0000000189708470-0x00000001897084D0
		// [Tooltip] // 0x0000000189708470-0x00000001897084D0
		private ButtonDownEventHandler _onButtonDown; // 0x1B0
		[CustomObfuscation] // 0x0000000189717160-0x00000001897171C0
		[SerializeField] // 0x0000000189717160-0x00000001897171C0
		// [Tooltip] // 0x0000000189717160-0x00000001897171C0
		private ButtonUpEventHandler _onButtonUp; // 0x1B8
		private Dictionary<int, PointerEventData> tTbkNLOsvXDQdRtrdKXoAuKlqSn; // 0x1C0
	
		// Properties
		public CustomControllerElementTargetSetForFloat targetCustomControllerElement { get => default; } // 0x0000000186A00410-0x0000000186A00470 
		public ButtonType buttonType { get => default; set {} } // 0x00000001869FFF30-0x00000001869FFF90 0x0000000186A01B70-0x0000000186A01C10
		public bool activateOnSwipeIn { get => default; set {} } // 0x00000001869FFDB0-0x00000001869FFE10 0x0000000186A01970-0x0000000186A01A30
		public bool stayActiveOnSwipeOut { get => default; set {} } // 0x0000000186A00390-0x0000000186A00410 0x0000000186A021E0-0x0000000186A02290
		public bool useDigitalAxisSimulation { get => default; set {} } // 0x0000000186A004D0-0x0000000186A00530 0x0000000186A02370-0x0000000186A02420
		public float digitalAxisGravity { get => default; set {} } // 0x00000001869FFF90-0x0000000186A00000 0x0000000186A01C10-0x0000000186A01CD0
		public float digitalAxisSensitivity { get => default; set {} } // 0x0000000186A00000-0x0000000186A00070 0x0000000186A01CD0-0x0000000186A01D60
		public TouchRegion touchRegion { get => default; set {} } // 0x0000000186A00470-0x0000000186A004D0 0x0000000186A02290-0x0000000186A02370
		public bool useTouchRegionOnly { get => default; set {} } // 0x0000000186A00530-0x0000000186A00590 0x0000000186A02420-0x0000000186A024D0
		public bool moveToTouchPosition { get => default; set {} } // 0x0000000186A00190-0x0000000186A001F0 0x0000000186A01EF0-0x0000000186A01F80
		public bool returnOnRelease { get => default; set {} } // 0x0000000186A002C0-0x0000000186A00320 0x0000000186A020A0-0x0000000186A02130
		public bool followTouchPosition { get => default; set {} } // 0x0000000186A00070-0x0000000186A000D0 0x0000000186A01D60-0x0000000186A01E10
		public bool animateOnMoveToTouch { get => default; set {} } // 0x00000001869FFE10-0x00000001869FFE70 0x0000000186A01A30-0x0000000186A01AC0
		public float moveToTouchSpeed { get => default; set {} } // 0x0000000186A001F0-0x0000000186A00260 0x0000000186A01F80-0x0000000186A02030
		public bool animateOnReturn { get => default; set {} } // 0x00000001869FFE70-0x00000001869FFED0 0x0000000186A01AC0-0x0000000186A01B70
		public float returnSpeed { get => default; set {} } // 0x0000000186A00320-0x0000000186A00390 0x0000000186A02130-0x0000000186A021E0
		public bool manageRaycasting { get => default; set {} } // 0x0000000186A00130-0x0000000186A00190 0x0000000186A01E10-0x0000000186A01EF0
		public int pointerId { get => default; set {} } // 0x0000000186A00260-0x0000000186A002C0 0x0000000186A02030-0x0000000186A020A0
		public bool hasPointer { get => default; } // 0x0000000186A000D0-0x0000000186A00130 
		internal StandaloneAxis axis { get => default; } // 0x00000001869FFED0-0x00000001869FFF30 
		private Action<vYIjyUMfsrLjixlJmTaeYJNvqmn> moveStartedDelegate { get => default; } // 0x00000001869FB700-0x00000001869FB7B0 
		private Action<vYIjyUMfsrLjixlJmTaeYJNvqmn> moveEndedDelegate { get => default; } // 0x00000001869FF290-0x00000001869FF340 
		private float axisValue { get => default; } // 0x00000001869FAAC0-0x00000001869FAB60 
		private float axisValuePrev { get => default; } // 0x00000001869FEFB0-0x00000001869FF050 
		private bool buttonValue { get => default; } // 0x00000001869FAED0-0x00000001869FAF50 
		private bool buttonValuePrev { get => default; } // 0x00000001869FE580-0x00000001869FE600 
		private int effectivePointerId { get => default; } // 0x0000000186A016B0-0x0000000186A01730 
	
		// Events
		public event UnityAction<float> AxisValueChangedEvent;
		public event UnityAction<bool> ButtonValueChangedEvent;
		public event UnityAction ButtonDownEvent;
		public event UnityAction ButtonUpEvent;
	
		// Nested types
		public enum ButtonType // TypeDefIndex: 3576
		{
			Standard = 0,
			ToggleSwitch = 1
		}
	
		private enum vYIjyUMfsrLjixlJmTaeYJNvqmn // TypeDefIndex: 3577
		{
			TCGihQKDgeeGtvEXifcuojmabzj = 0,
			euXYneYPthVhveBWhDzbgcsApkRZ = 1,
			HwWCoknLLuvDCNsHCSIjJkwLMtB = 2
		}
	
		private enum vwOsOGNXaoaruwxhzgqJCegchQrA // TypeDefIndex: 3578
		{
			UMtjEaOogDDwQiplOLpTuwxTdbQ = 0,
			qBvlHFfTVaijZsMuBaXfTPCbahL = 1
		}
	
		[Serializable]
		public class AxisValueChangedEventHandler : UnityEvent<float> // TypeDefIndex: 3579
		{
			// Constructors
			public AxisValueChangedEventHandler() {} // 0x00000001869F80D0-0x00000001869F8140
		}
	
		[Serializable]
		public class ButtonValueChangedEventHandler : UnityEvent<bool> // TypeDefIndex: 3580
		{
			// Constructors
			public ButtonValueChangedEventHandler() {} // 0x00000001869F8200-0x00000001869F8270
		}
	
		[Serializable]
		public class ButtonDownEventHandler : UnityEvent // TypeDefIndex: 3581
		{
			// Constructors
			public ButtonDownEventHandler() {} // 0x00000001869F8140-0x00000001869F81A0
		}
	
		[Serializable]
		public class ButtonUpEventHandler : UnityEvent // TypeDefIndex: 3582
		{
			// Constructors
			public ButtonUpEventHandler() {} // 0x00000001869F81A0-0x00000001869F8200
		}
	
		// Constructors
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		private TouchButton() {} // 0x00000001869FEC70-0x00000001869FEFB0
	
		// Methods
		public void SetRawValue(float value) {} // 0x00000001869FE0A0-0x00000001869FE130
		public void SetDefaultPosition() {} // 0x00000001869FE010-0x00000001869FE0A0
		private void xbYqhNfPiSuHkPeDMsDiMfQJiRv(Vector2 param_00007eb1) {} // 0x0000000186A02710-0x0000000186A027A0
		public void ReturnToDefaultPosition(bool instant) {} // 0x00000001869FDCD0-0x00000001869FDD90
		public void ReturnToDefaultPosition() {} // 0x00000001869FDD90-0x00000001869FDE10
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void Awake() {} // 0x00000001869FA760-0x00000001869FA800
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnEnable() {} // 0x00000001869FCAC0-0x00000001869FCBD0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnDisable() {} // 0x00000001869FCA10-0x00000001869FCAC0
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void OnValidate() {} // 0x00000001869FD990-0x00000001869FDA90
		[CustomObfuscation] // 0x0000000189ABE840-0x0000000189ABE870
		internal override void Reset() {} // 0x00000001869FDC60-0x00000001869FDCD0
		internal override void OnUpdate() {} // 0x00000001869FD800-0x00000001869FD990
		internal override bool OnInitialize() => default; // 0x00000001869FCBD0-0x00000001869FCC40
		internal override void OnCustomControllerUpdate() {} // 0x00000001869FC880-0x00000001869FCA10
		internal override void OnSubscribeEvents() {} // 0x00000001869FD470-0x00000001869FD630
		internal override void OnUnsubscribeEvents() {} // 0x00000001869FD630-0x00000001869FD800
		internal override void OnSetProperty() {} // 0x00000001869FD3A0-0x00000001869FD470
		internal override void OnClear() {} // 0x00000001869FC6E0-0x00000001869FC880
		public override void ClearValue() {} // 0x00000001869FA980-0x00000001869FAAC0
		internal override bool IsPressed() => default; // 0x00000001869FBBB0-0x00000001869FBC70
		internal override bool IsThisOrTouchRegionGameObject(GameObject gameObject) => default; // 0x00000001869FBC70-0x00000001869FBDC0
		private void TfNmSnGnpngwyaeoaJynHLedvQZ() {} // 0x00000001869FE130-0x00000001869FE210
		private void zjMKBxqOgwPmpEClcPfpjHXaBkZ() {} // 0x0000000186A02950-0x0000000186A02B80
		private void ZAIBJyFskuHqKsgCRyaGDwPriJl() {} // 0x00000001869FE9D0-0x00000001869FEC70
		private void hOqmqOAIOZLRmDMQVNtxmmyPjmN(float param_00007eb4, bool param_00007eb5) {} // 0x0000000186A00590-0x0000000186A006A0
		private void KeZsCUrjBWAXHpcDBjgHggzgjRn() {} // 0x00000001869FC450-0x00000001869FC5B0
		private void MpKdXGgKmgAqQdDxmXYWSFTTKekf() {} // 0x00000001869FC5B0-0x00000001869FC650
		private new void NVWqZPEZaDhGVdcEuqvABdsUKUL() {} // 0x00000001869FC650-0x00000001869FC6E0
		private void BpIrxrTAZovcjjJKjdrhqiRYbUtH() {} // 0x00000001869FA800-0x00000001869FA8F0
		private bool jRYzOZIJAJApqJNFeBYzaySiWHvl() => default; // 0x0000000186A006A0-0x0000000186A00750
		private void WgGdgRGLGuNKILyWzVQUgvhaIKf(TouchRegion param_00007eb6) {} // 0x00000001869FE380-0x00000001869FE580
		private void ScBbWfMbGgWRkVPrsqLkpPjeHhR(TouchRegion param_00007eb7) {} // 0x00000001869FDE10-0x00000001869FE010
		private void dByKttBtodosJPFybBXLHsYfHmZw() {} // 0x00000001869FF340-0x00000001869FF450
		private void EngeuFiINqVonFKGMsOZSqAIstKQ(Vector2 param_00007eb8, bool param_00007eb9, float param_00007eba, vYIjyUMfsrLjixlJmTaeYJNvqmn param_00007ebb) {} // 0x00000001869FAB60-0x00000001869FAED0
		private void KXGXneOjslBgCoFxDokJHtUpHCr(Vector2 param_00007ebc, PositionType param_00007ebd, bool param_00007ebe, float param_00007ebf, vYIjyUMfsrLjixlJmTaeYJNvqmn param_00007ec0) {} // 0x00000001869FBDC0-0x00000001869FC450
		private IEnumerator YwNxjLvllECYgmvWvRLPlgYahiJ(Vector2 param_00007ec1, PositionType param_00007ec2, float param_00007ec3, vYIjyUMfsrLjixlJmTaeYJNvqmn param_00007ec4) => default; // 0x00000001869FE8D0-0x00000001869FE9D0
		private void yFIryXiFmAheSzYjuuUCpBvLoYn(vYIjyUMfsrLjixlJmTaeYJNvqmn param_00007ec5, Vector2 param_00007ec6, PositionType param_00007ec7) {} // 0x0000000186A027A0-0x0000000186A02950
		private void ebwjYhEqRdpMXwLKPVkBqUQNcEDa(vYIjyUMfsrLjixlJmTaeYJNvqmn param_00007ec8) {} // 0x00000001869FFB40-0x00000001869FFDB0
		private void juHmsVQdOwsmtGcmTviVInzkJKk(vYIjyUMfsrLjixlJmTaeYJNvqmn param_00007ec9) {} // 0x0000000186A00750-0x0000000186A009D0
		private void dyGGqqDNKdJMvZlREoTIYHXTftYS(int param_00007eca) {} // 0x00000001869FF5E0-0x00000001869FF720
		private void CgelQMRxKcNpSeEdjHrUgepUNWaw() {} // 0x00000001869FA8F0-0x00000001869FA980
		private void GLnFKkzcjTCAOtkTuThfdBcbeFU() {} // 0x00000001869FB7B0-0x00000001869FB950
		private bool eOHzHpzQRbBLjxcuQVfnfVkaPND() => default; // 0x00000001869FFA80-0x00000001869FFB40
		private void IVWagqmpVqfBssUpPTaUIrMVFpo() {} // 0x00000001869FBB40-0x00000001869FBBB0
		private bool xJRpUEtiZlPsigLVVURBBlekxkJ(int param_00007ecb) => default; // 0x0000000186A02640-0x0000000186A02710
		private PointerEventData FcNxJWJevjAfECcjXghibLdzawa(int param_00007ecc, GameObject param_00007ecd) => default; // 0x00000001869FAF50-0x00000001869FB700
		private PointerEventData YmNTOnqdWUarvHWIAOOUMxyMuVXg(int param_00007ece) => default; // 0x00000001869FE600-0x00000001869FE8D0
		private void uhbxZnhdAiTocMkidbifwylOKNg(PointerEventData param_00007ecf) {} // 0x0000000186A024D0-0x0000000186A025A0
		private PointerEventData eHumJbgUTelnpVVEEkJoClmMzSA(int param_00007ed0) => default; // 0x00000001869FF720-0x00000001869FFA80
		private void RTFkZgwwfqcoraXUeOtRrGPTipR(PointerEventData param_00007ed1, vwOsOGNXaoaruwxhzgqJCegchQrA param_00007ed2) {} // 0x00000001869FDA90-0x00000001869FDC60
		private void oyVgIoryHcoeYsQAABSabldnFuw(PointerEventData param_00007ed3, vwOsOGNXaoaruwxhzgqJCegchQrA param_00007ed4) {} // 0x0000000186A01350-0x0000000186A01540
		private void kniQNhRGNrdKgAIpgLeavFJtBJvU(PointerEventData param_00007ed5, vwOsOGNXaoaruwxhzgqJCegchQrA param_00007ed6) {} // 0x0000000186A009D0-0x0000000186A00EC0
		private void AQKFYYuUyzWMUiyIguWHpBOybED(PointerEventData param_00007ed7, vwOsOGNXaoaruwxhzgqJCegchQrA param_00007ed8) {} // 0x00000001869FA500-0x00000001869FA6A0
		private void oPbGWVlpSTmnotbhVEcMMsRAWvN(int param_00007ed9, Vector2 param_00007eda, vwOsOGNXaoaruwxhzgqJCegchQrA param_00007edb) {} // 0x0000000186A01220-0x0000000186A01350
		private void lvEXyedGHJXClGybBOaYBiVqimu() {} // 0x0000000186A00EC0-0x0000000186A010D0
		internal override void OnPointerDown(PointerEventData eventData) {} // 0x00000001869FCC40-0x00000001869FCE30
		internal override void OnPointerUp(PointerEventData eventData) {} // 0x00000001869FD1B0-0x00000001869FD3A0
		internal override void OnPointerEnter(PointerEventData eventData) {} // 0x00000001869FCE30-0x00000001869FCFD0
		internal override void OnPointerExit(PointerEventData eventData) {} // 0x00000001869FCFD0-0x00000001869FD1B0
		private void WIePpjCcsUBMIhAWGtGpDSlJlip(PointerEventData param_00007ee0) {} // 0x00000001869FE210-0x00000001869FE380
		private void pEabpejZnFXyFYVtSEnxCGboYRd(PointerEventData param_00007ee1) {} // 0x0000000186A01540-0x0000000186A016B0
		private void dcgoqSOZQngElokwIQkKjPdIlML(PointerEventData param_00007ee2) {} // 0x00000001869FF450-0x00000001869FF5E0
		private void mErQunVxoylvoyoLVaOLThnRYfr(PointerEventData param_00007ee3) {} // 0x0000000186A010D0-0x0000000186A01220
		private void HWFhkFlLkYUKyhTUFbGsyGCYFc(float param_00007ee4) {} // 0x00000001869FBA30-0x00000001869FBB40
		private void HQgAhyJhrHYQKAXbJAataYJekULw(bool param_00007ee5) {} // 0x00000001869FB950-0x00000001869FBA30
		private void AwISkEnBouIcuKglDYyFpRHuHNVl() {} // 0x00000001869FA6A0-0x00000001869FA760
		private void vulYfrBZeVCgrYGRTBzfraHLDodh() {} // 0x0000000186A025A0-0x0000000186A02640
	}
}
