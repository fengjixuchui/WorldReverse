/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Cinemachine.Utility
{
	internal abstract class GaussianWindow1d<T> // TypeDefIndex: 6849
	{
		// Fields
		protected T[] mData;
		protected float[] mKernel;
		protected float mKernelSum;
		protected int mCurrentPos;
	
		// Properties
		public float Sigma { get; private set; }
		public int KernelSize { get; }
	
		// Constructors
		protected GaussianWindow1d() {} // Dummy constructor
		public GaussianWindow1d(float sigma, int maxKernelRadius = 10 /* Metadata: 0x00ADDF58 */) {}
	
		// Methods
		private void GenerateKernel(float sigma, int maxKernelRadius) {}
		protected abstract T Compute(int windowPos);
		public void Reset() {}
		public bool IsEmpty() => default;
		public void AddValue(T v) {}
		public T Filter(T v) => default;
		public T Value() => default;
	}
}
