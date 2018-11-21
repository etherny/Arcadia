#if NET_4_6
using UnityEngine;
using UnityEngine.EventSystems;
using clojure.lang;

public class OnNetworkingEventHook : ArcadiaBehaviour, Game.Networking.NetworkingEvent
{
  public void OnConnected()
  {
      RunFunctions();
  }
}
#endif