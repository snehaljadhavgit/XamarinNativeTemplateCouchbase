package md5106401c65d02fd876ac619499d1eaacb;


public class RowListAdapter
	extends android.widget.BaseAdapter
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_getItem:(I)Ljava/lang/Object;:GetGetItem_IHandler\n" +
			"n_getCount:()I:GetGetCountHandler\n" +
			"n_getItemId:(I)J:GetGetItemId_IHandler\n" +
			"n_getView:(ILandroid/view/View;Landroid/view/ViewGroup;)Landroid/view/View;:GetGetView_ILandroid_view_View_Landroid_view_ViewGroup_Handler\n" +
			"";
		mono.android.Runtime.register ("XamarinNativeTemplate.Droid.Adapter.RowListAdapter, XamarinNativeTemplate.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", RowListAdapter.class, __md_methods);
	}


	public RowListAdapter ()
	{
		super ();
		if (getClass () == RowListAdapter.class)
			mono.android.TypeManager.Activate ("XamarinNativeTemplate.Droid.Adapter.RowListAdapter, XamarinNativeTemplate.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}

	public RowListAdapter (md553f6b5680d90f18597506114faf46fc1.MainActivity p0)
	{
		super ();
		if (getClass () == RowListAdapter.class)
			mono.android.TypeManager.Activate ("XamarinNativeTemplate.Droid.Adapter.RowListAdapter, XamarinNativeTemplate.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "XamarinNativeTemplate.Droid.MainActivity, XamarinNativeTemplate.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", this, new java.lang.Object[] { p0 });
	}


	public java.lang.Object getItem (int p0)
	{
		return n_getItem (p0);
	}

	private native java.lang.Object n_getItem (int p0);


	public int getCount ()
	{
		return n_getCount ();
	}

	private native int n_getCount ();


	public long getItemId (int p0)
	{
		return n_getItemId (p0);
	}

	private native long n_getItemId (int p0);


	public android.view.View getView (int p0, android.view.View p1, android.view.ViewGroup p2)
	{
		return n_getView (p0, p1, p2);
	}

	private native android.view.View n_getView (int p0, android.view.View p1, android.view.ViewGroup p2);

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
