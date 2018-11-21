#if NET_4_6
using UnityEngine;
using clojure.lang;
using Photon;

public class OnPhotonJoinedLobbyHook : ArcadiaBehaviour
{
  public void OnJoinedLobby()
  {
      RunFunctions();
  }
}
#endif