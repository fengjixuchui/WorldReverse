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
	public class MonoHomeworldEditPage : MonoBehaviour // TypeDefIndex: 31005
	{
		// Fields
		public GameObject typeBtnPrefab; // 0x18
		public GameObject itemBtnPrefab; // 0x20
		public UnityEngine.UI.Text debugText; // 0x28
		public Transform typeTransformParent; // 0x30
		public Transform itemTransformParent; // 0x38
		public MonoInputEasyTouch_H4 touchControl; // 0x40
		public MonoJoyStick_H4 moveControl; // 0x48
		public float magnetRadius; // 0x50
		public float alignMagnetRadius; // 0x54
		public float magnetAlignAngle; // 0x58
		public Transform operationGrp; // 0x60
		public Button saveEditBtn; // 0x68
		public Button clearEditBtn; // 0x70
		public Button lastSaveBtn; // 0x78
		public Button closeBtn; // 0x80
		public Button npcBtn; // 0x88
		public Button nextRoomBtn; // 0x90
		public Transform editBtnGrp; // 0x98
		public Button editConfirmBtn; // 0xA0
		public Button editRotateBtn; // 0xA8
		public Button editRemoveBtn; // 0xB0
		public Button editCancelBtn; // 0xB8
		public Transform editRotateBtnGrp; // 0xC0
		public Button editRotateConfirmBtn; // 0xC8
		public Button editRotate90Btn; // 0xD0
		public Button editRotateCancelBtn; // 0xD8
		public GameObject rotateSphereBtn; // 0xE0
		public MonoInputEasyTouch_H4 touch_H4; // 0xE8
		public Transform editFuncBtnGrp; // 0xF0
		public Button gridBtn; // 0xF8
		public Button alignBtn; // 0x100
		public Button toggleRotBtn; // 0x108
		public GameObject gridPrefab; // 0x110
		public float gridSize; // 0x118
		public UnityEngine.Material gridGreenMat; // 0x120
		public UnityEngine.Material gridRedMat; // 0x128
		protected List<GameObject> typeObjs; // 0x130
		protected List<GameObject> itemObjs; // 0x138
		protected List<GameObject> gridObjs; // 0x140
		protected Stack<GameObject> reuseObjs; // 0x148
		protected bool _gridObjCollision; // 0x150
		protected Vector3 _rotateDiscScale; // 0x154
		protected float _magnetAlignDot; // 0x160
	
		// Properties
		public float magnetAlighDot { /* [XID] */ /* 0x00000001898A2D10-0x00000001898A2D30 */ get => default; } // 0x0000000184B6A040-0x0000000184B6A0F0 
	
		// Constructors
		public MonoHomeworldEditPage() {} // 0x0000000184B69ED0-0x0000000184B6A040
	
		// Methods
		// [XID] // 0x00000001898AA230-0x00000001898AA250
		private void OnEnable() {} // 0x0000000184B67310-0x0000000184B67400
		// [XID] // 0x00000001898B1C30-0x00000001898B1C50
		public void SetupTypeButtons(int num, Action<Transform, int> initCallback) {} // 0x0000000184B69300-0x0000000184B69550
		// [XID] // 0x00000001898B9850-0x00000001898B9870
		public void SetupItemButtons(int num, Action<Transform, int> initCallback) {} // 0x0000000184B690B0-0x0000000184B69300
		// [XID] // 0x00000001898C0C70-0x00000001898C0C90
		public void SetMenuEnable(bool enable) {} // 0x0000000184B67B60-0x0000000184B67DB0
		// [XID] // 0x00000001898C8510-0x00000001898C8530
		public void ClearItems() {} // 0x0000000184B66F40-0x0000000184B671F0
		// [XID] // 0x00000001898CFF20-0x00000001898CFF40
		public void SetupCameraSetting(HomeworldEditCameraSetting setting) {} // 0x0000000184B68150-0x0000000184B68290
		// [XID] // 0x00000001898D74F0-0x00000001898D7510
		public void SetDebugText(string text) {} // 0x0000000184B67740-0x0000000184B67810
		// [XID] // 0x00000001898DF240-0x00000001898DF260
		public void ShowEditPanel(GadgetEntity editGadget, bool show) {} // 0x0000000184B69550-0x0000000184B69780
		// [XID] // 0x00000001898E6C20-0x00000001898E6C40
		public void SetEditConfirmBtnEnable(bool enable) {} // 0x0000000184B67810-0x0000000184B67910
		// [XID] // 0x00000001898EE350-0x00000001898EE370
		public void SetTopLevelBtnEnable(bool enable) {} // 0x0000000184B67EB0-0x0000000184B68150
		// [XID] // 0x00000001898F5BA0-0x00000001898F5BC0
		public void UpdateEditPanelPos(GadgetEntity editGadget) {} // 0x0000000184B69B90-0x0000000184B69D30
		// [XID] // 0x00000001898FD340-0x00000001898FD360
		public void UpdateRotateEditPanelPos(GadgetEntity editGadget) {} // 0x0000000184B69D30-0x0000000184B69ED0
		// [XID] // 0x0000000189904C20-0x0000000189904C40
		public void ShowEditRotatePanel(GadgetEntity editGadget, bool show, FurnitureDeploySurfaceType surfaceType = FurnitureDeploySurfaceType.Ground /* Metadata: 0x00B11D82 */) {} // 0x0000000184B69780-0x0000000184B69B90
		// [XID] // 0x000000018990C440-0x000000018990C460
		public void SetRotatePanelConfirmEnable(bool enable) {} // 0x0000000184B67DB0-0x0000000184B67EB0
		// [XID] // 0x0000000189913D30-0x0000000189913D50
		public void SetCameraRotateEnable(bool pitch, bool yaw, HomeworldEditCameraSetting setting) {} // 0x0000000184B67400-0x0000000184B67580
		// [XID] // 0x000000018991B6A0-0x000000018991B6C0
		public void SetFocusOnItem(GameObject focusObj) {} // 0x0000000184B67910-0x0000000184B67B60
		// [XID] // 0x0000000189922C40-0x0000000189922C60
		public void SetupCollisionGridForGadget(GadgetEntity entity, MonoHomeworldPlaceCol placeCol, bool isWall = false /* Metadata: 0x00B11D86 */) {} // 0x0000000184B68290-0x0000000184B690B0
		// [XID] // 0x000000018992A530-0x000000018992A550
		protected GameObject GetGridFromStack() => default; // 0x0000000184B671F0-0x0000000184B67310
		// [XID] // 0x0000000189931AE0-0x0000000189931B00
		public void SetCollisionGridState(bool isCollide, bool forceRefresh = false /* Metadata: 0x00B11D87 */) {} // 0x0000000184B67580-0x0000000184B67740
		// [XID] // 0x0000000189939540-0x0000000189939560
		public void ClearCollisionGrid() {} // 0x0000000184B66D10-0x0000000184B66F40
	}
}
