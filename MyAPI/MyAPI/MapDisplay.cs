﻿using UnityEngine;

namespace ProceduralTerrainAPI
{
    public class MapDisplay : MonoBehaviour
    {
        [SerializeField] private MeshRenderer textureRenderer;
        public MeshFilter meshFilter;
        public MeshRenderer meshRenderer;

        public void DrawTexture(Texture2D texture)
        {
            textureRenderer.sharedMaterial.mainTexture = texture;
            textureRenderer.transform.localScale = new Vector3(texture.width, 1, texture.height);
        }

        public void DrawMesh(MeshData meshData, Texture2D texture)
        {
            meshFilter.sharedMesh = meshData.CreateMesh();
            meshRenderer.sharedMaterial.mainTexture = texture;
        }
    }
}
