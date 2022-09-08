/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security;
using UnityEngine;

// Image 60: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null - Types 10700-32500

public class GeneralIntee<T> : IGeneralIntee // TypeDefIndex: 29666
{
	// Fields
	private GeneralInteeType type;
	private string inteeHint;
	private Action<T> callback;
	public T callbackParam;
	private uint instanceID;
	private string inteeIconName;
	private bool isLowPriority;
	private bool interactable;
	private Color textColor;
	private bool doActionOnce;
	private GeneralInteeIconType iconType;
	private bool initialized;

	// Constructors
	public GeneralIntee() {}

	// Methods
	public void Init(uint id, GeneralInteeType t, string hint, T param, Action<T> action, bool lowPriority = false /* Metadata: 0x00B0FBA5 */, bool interact = true /* Metadata: 0x00B0FBA6 */, bool doOnce = false /* Metadata: 0x00B0FBA7 */) {}
	public void SetIconName(GeneralInteeIconType type, string name) {}
	public GeneralInteeIconType GetInteeIconType() => default;
	public void SetTextColor(Color c) {}
	public Color GetTextColor() => default;
	public GeneralInteeType GetInteeType() => default;
	public uint GetInstanceID() => default;
	public void DoAction() {}
	public string GetHint() => default;
	public bool IsInteractable() => default;
	public bool GetIsLowPriority() => default;
	public void Dispose() {}
	public string GetIconName() => default;
}

