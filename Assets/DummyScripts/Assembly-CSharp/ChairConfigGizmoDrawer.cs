/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

[ExecuteInEditMode] // 0x00000001897B1BA0-0x00000001897B1BB0
public class ChairConfigGizmoDrawer : MonoBehaviour // TypeDefIndex: 31777
{
	// Fields
	private SceneChairConfig _chairConfig; // 0x18
	private SceneChairObject _chairObject; // 0x20
	private GameObject _avatarObj; // 0x28
	public Animator _avatarAnimator; // 0x30
	public string animName; // 0x38
	private int _avatarSitIndex; // 0x40
	private List<Vector3> _sitPointPos; // 0x48
	private List<Vector3> _slotPos; // 0x50
	private List<int> _slotSitPoints; // 0x58
	private Dictionary<SceneChairConfig.SitDirection, string> _dirStrMap; // 0x60

	// Constructors
	public ChairConfigGizmoDrawer() {} // 0x00000001843DE470-0x00000001843DE5C0

	// Methods
	private void Awake() {} // 0x00000001843DD990-0x00000001843DD9E0
	public void SetVisualizeChairConfig(SceneChairConfig newConfig, SceneChairObject chairObj) {} // 0x00000001843DDBC0-0x00000001843DDC40
	public void SetAvatar(GameObject avatarObj) {} // 0x00000001843DDB00-0x00000001843DDBC0
	public void SetAvatarAnimConfig(string sitAnimNanme = "Sit" /* Metadata: 0x00B136CE */, float sitdownTime = 0.55f /* Metadata: 0x00B136D5 */, float sitIdleTime = 2f /* Metadata: 0x00B136D9 */) {} // 0x00000001843DDA40-0x00000001843DDAA0
	public void SetAvatarSitPoint(int sitIndex, SceneChairConfig.SitDirection enterDir) {} // 0x00000001843DDAA0-0x00000001843DDB00
	private void Update() {} // 0x00000001843DE400-0x00000001843DE470
	private void OnDrawGizmos() {} // 0x00000001843DD9E0-0x00000001843DDA40
	private void UpdateSitPointGizmos() {} // 0x00000001843DDF00-0x00000001843DE400
	private void UpdateAvatarAnim() {} // 0x00000001843DDC40-0x00000001843DDD70
	private void UpdateAvatarSitTransform() {} // 0x00000001843DDD70-0x00000001843DDF00
}

