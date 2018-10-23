package md5106401c65d02fd876ac619499d1eaacb;


public class RowListAdapterHolder
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("XamarinNativeTemplate.Droid.Adapter.RowListAdapterHolder, XamarinNativeTemplate.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RowListAdapterHolder.class, __md_methods);
	}


	public RowListAdapterHolder ()
	{
		super ();
		if (getClass () == RowListAdapterHolder.class)
			mono.android.TypeManager.Activate ("XamarinNativeTemplate.Droid.Adapter.RowListAdapterHolder, XamarinNativeTemplate.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
