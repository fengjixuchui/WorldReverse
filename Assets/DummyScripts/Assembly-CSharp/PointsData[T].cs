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

public class PointsData<T> // TypeDefIndex: 32147
{
	// Fields
	[SerializeField] // 0x0000000189BC8500-0x0000000189BC8510
	protected T[] _points;
	protected bool _dirty;
	protected List<T> _pointList;

	// Properties
	public T[] points { get => default; }

	// Constructors
	public PointsData() {}

	// Methods
	public void Refresh() {}
	public void AddPoint(T point) {}
	public void AddPoint(T point, int index) {}
	public void SetPoint(T point, int index) {}
	public void RemovePoint(int index) {}
	public void Clear() {}
}

