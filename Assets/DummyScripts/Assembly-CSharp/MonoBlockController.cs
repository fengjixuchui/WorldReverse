/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class MonoBlockController : MonoBehaviour // TypeDefIndex: 30706
{
	// Fields
	private Animator _animator; // 0x18
	public Transform moveTo; // 0x20
	public Vector3 moveOffest; // 0x28
	private Vector3 _startPos; // 0x34
	private bool _isEnd; // 0x40
	private float _speed; // 0x44
	private static int _shaderParamName; // 0x00
	private Renderer _renderer; // 0x48
	private MaterialPropertyBlock _mpb; // 0x50
	private float _detaTime; // 0x58
	private float _curTime; // 0x5C
	private float lightValue; // 0x60
	private float targetLight; // 0x64
	private float curLight; // 0x68
	private float afterTime; // 0x6C
	private float lightSpeed1; // 0x70
	private float lightSpeed2; // 0x74
	private int emissionCount; // 0x78

	// Constructors
	public MonoBlockController() {} // 0x0000000181D81F80-0x0000000181D82080
	static MonoBlockController() {} // 0x0000000181D81F10-0x0000000181D81F80

	// Methods
	protected void Awake() {} // 0x0000000181D80FE0-0x0000000181D811B0
	private void OnEnable() {} // 0x0000000181D815D0-0x0000000181D816C0
	private void Init() {} // 0x0000000181D813E0-0x0000000181D81450
	private void InitAnimator() {} // 0x0000000181D81300-0x0000000181D813E0
	public void SetSpeed(float speed, bool force) {} // 0x0000000181D81A90-0x0000000181D81B70
	public void SetGoal(Transform goal, Vector3 offest) {} // 0x0000000181D81A10-0x0000000181D81A90
	public void SetEnd() {} // 0x0000000181D818F0-0x0000000181D81A10
	public void Restart() {} // 0x0000000181D816C0-0x0000000181D81840
	public void LateUpdate() {} // 0x0000000181D81450-0x0000000181D815D0
	public void UpdateAnimation(float detaTime, float liftDistance) {} // 0x0000000181D81B70-0x0000000181D81DB0
	public void SetEmissionParam(float value, float speed1, float speed2, float begin, float af) {} // 0x0000000181D81840-0x0000000181D818F0
	private void UpdateLight() {} // 0x0000000181D81DB0-0x0000000181D81F10
	public void EnableLight(float lightValue) {} // 0x0000000181D811B0-0x0000000181D81300
}

