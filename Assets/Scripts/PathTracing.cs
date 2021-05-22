
using UnityEngine;


public class PathTracing : MonoBehaviour
{
   [SerializeField] private LineRenderer pathRenderer;

   // renderer path from mover
   public void RenderPath(Vector3[] path)
   {
      pathRenderer.positionCount = path.Length;
      pathRenderer.SetPositions(path);
   }
}
