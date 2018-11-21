#if NET_4_6
using UnityEngine;
using clojure.lang;

public class OnPhotonConnectedToMasterHook : ArcadiaBehaviour, IPunCallbacks
{
  public void OnConnectedToMaster()
  {
      RunFunctions();
  }
}
#endif