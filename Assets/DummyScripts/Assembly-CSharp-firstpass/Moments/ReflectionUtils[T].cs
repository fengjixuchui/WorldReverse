/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

// Image 59: Assembly-CSharp-firstpass.dll - Assembly: Assembly-CSharp-firstpass, Version=1.0.2.0, Culture=neutral, PublicKeyToken=null - Types 6705-10699

namespace Moments
{
	public class ReflectionUtils<T> // TypeDefIndex: 7568
		where T : class, new()
	{
		// Fields
		private readonly T _Instance;
	
		// Constructors
		public ReflectionUtils() {} // Dummy constructor
		public ReflectionUtils(T instance) {}
	
		// Methods
		public string GetFieldName<U>(Expression<Func<T, U>> fieldAccess) => default;
		public FieldInfo GetField(string fieldName) => default;
		public A GetAttribute<A>(FieldInfo field)
			where A : Attribute => default;
		public void ConstrainMin<U>(Expression<Func<T, U>> fieldAccess, float value) {}
		public void ConstrainMin<U>(Expression<Func<T, U>> fieldAccess, int value) {}
		public void ConstrainRange<U>(Expression<Func<T, U>> fieldAccess, float value) {}
		public void ConstrainRange<U>(Expression<Func<T, U>> fieldAccess, int value) {}
	}
}
