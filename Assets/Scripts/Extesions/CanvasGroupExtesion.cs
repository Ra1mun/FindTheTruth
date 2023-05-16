 using UnityEngine;

 public static class CanvasGroupExtesion
 {
     public static void Open(this CanvasGroup canvasGroup)
     {
         canvasGroup.alpha = 1f;
         canvasGroup.interactable = true;
         canvasGroup.blocksRaycasts = true;
     }

     public static void Close(this CanvasGroup canvasGroup)
     {
         canvasGroup.alpha = 0f;
         canvasGroup.interactable = false;
         canvasGroup.blocksRaycasts = false;
     }
     
     public static void Set(this CanvasGroup canvasGroup, float alpha, bool interactable, bool blocksRaycast)
     {
         canvasGroup.alpha = alpha;
         canvasGroup.interactable = interactable;
         canvasGroup.blocksRaycasts = blocksRaycast;
     }
 }
