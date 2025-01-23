using System;

[assembly:global::Android.Runtime.NamespaceMapping (Java = "com.example.androidlibrary", Managed="Com.Example.Androidlibrary")]

delegate double _JniMarshal_PPD_D (IntPtr jnienv, IntPtr klass, double p0);
delegate double _JniMarshal_PPDD_D (IntPtr jnienv, IntPtr klass, double p0, double p1);
delegate double _JniMarshal_PPII_D (IntPtr jnienv, IntPtr klass, int p0, int p1);
delegate int _JniMarshal_PPII_I (IntPtr jnienv, IntPtr klass, int p0, int p1);
#if !NET
namespace System.Runtime.Versioning {
    [System.Diagnostics.Conditional("NEVER")]
    [AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Constructor | AttributeTargets.Enum | AttributeTargets.Event | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Method | AttributeTargets.Module | AttributeTargets.Property | AttributeTargets.Struct, AllowMultiple = true, Inherited = false)]
    internal sealed class SupportedOSPlatformAttribute : Attribute {
        public SupportedOSPlatformAttribute (string platformName) { }
    }
}
#endif

