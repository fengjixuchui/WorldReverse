/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

public class MenuLayout // TypeDefIndex: 9754
{
	// Fields
	private int width; // 0x10
	private int height; // 0x14
	private int ySpace; // 0x18
	private int x; // 0x1C
	private int y; // 0x20
	private GUIStyle style; // 0x28
	private GUIStyle styleSelected; // 0x30
	private int selectedItemIndex; // 0x38
	private bool buttonPressed; // 0x3C
	private bool backButtonPressed; // 0x3D
	private int numItems; // 0x40
	private int fontSize; // 0x44
	private static float timeOfLastChange; // 0x00
	private int currCount; // 0x48
	private IScreen owner; // 0x50

	// Constructors
	public MenuLayout() {} // Dummy constructor
	public MenuLayout(IScreen screen, int itemWidth, int itemFontSize) {} // 0x0000000186D20E20-0x0000000186D20ED0
	static MenuLayout() {} // 0x0000000186D20DC0-0x0000000186D20E20

	// Methods
	public IScreen GetOwner() => default; // 0x0000000186D207A0-0x0000000186D20800
	public void DoLayout() {} // 0x0000000186D20590-0x0000000186D207A0
	public void SetSelectedItem(int index) {} // 0x0000000186D20CD0-0x0000000186D20D50
	public void ItemNext() {} // 0x0000000186D20BF0-0x0000000186D20C60
	public void ItemPrev() {} // 0x0000000186D20C60-0x0000000186D20CD0
	public void Update() {} // 0x0000000186D20D50-0x0000000186D20DC0
	public void HandleInput() {} // 0x0000000186D208B0-0x0000000186D20BF0
	private bool AddButton(string text, bool enabled = true /* Metadata: 0x00AE622A */, bool selected = false /* Metadata: 0x00AE622B */) => default; // 0x0000000186D20310-0x0000000186D204B0
	public bool AddItem(string name, bool enabled = true /* Metadata: 0x00AE622C */) => default; // 0x0000000186D204B0-0x0000000186D20590
	public bool AddBackIndex(string name, bool enabled = true /* Metadata: 0x00AE622D */) => default; // 0x0000000186D20220-0x0000000186D20310
	public Rect GetRect() => default; // 0x0000000186D20800-0x0000000186D208B0
}

