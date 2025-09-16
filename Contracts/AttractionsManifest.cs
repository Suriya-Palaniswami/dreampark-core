using UnityEngine;

namespace DreamPark.Core.Contracts {
  [CreateAssetMenu(menuName="DreamPark/Attraction Manifest")]
  public class AttractionManifest : ScriptableObject {
    public string id;
    public string sceneKey;
    public string[] warmupLabels;
  }
}
