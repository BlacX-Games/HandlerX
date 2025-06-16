using UnityEngine;
using UnityEditor;
using TMPro;
using System.Collections.Generic;
using System.Linq;

namespace BlacXGames.Plugins.Utilities.Uch.Editor
{
    public class TMPHandlerEditor : EditorWindow
    {
        [MenuItem("Tools/BlacXGames/TMPHandler/Apply All")]
        public static void AddTMPHandlersToAll()
        {
            // Find all TextMeshProUGUI components in the scene
            TextMeshProUGUI[] textMeshProUGUI = FindObjectsOfType<TextMeshProUGUI>();
            
            // Keep track of stats for reporting
            int componentsAdded = 0;
            int componentsSkipped = 0;
            List<string> objectsModified = new List<string>();
            
            // Begin tracking changes for undo
            Undo.SetCurrentGroupName("Add TMPHandlers");
            int undoGroupIndex = Undo.GetCurrentGroup();
            
            foreach (TextMeshProUGUI item in textMeshProUGUI)
            {
                // Skip if the component already has a TMPHandler
                if (item.GetComponent<TMPHandler>() != null)
                {
                    componentsSkipped++;
                    continue;
                }
                
                // Register the object for undo
                Undo.RecordObject(item.gameObject, "Add TMPHandler");
                
                // Add the TMPHandler component
                TMPHandler handler = Undo.AddComponent<TMPHandler>(item.gameObject);
                
                // Mark the object as dirty so it gets saved
                EditorUtility.SetDirty(item.gameObject);
                
                componentsAdded++;
                objectsModified.Add(item.gameObject.name);
            }
            
            // End the undo group
            Undo.CollapseUndoOperations(undoGroupIndex);
            
            // Report results
            if (componentsAdded > 0)
            {
                Debug.Log($"Added TMPHandler to {componentsAdded} TextMeshProUGUI components. Skipped {componentsSkipped} components that already had handlers.");
                ShowResultsDialog(componentsAdded, componentsSkipped, objectsModified);
            }
            else
            {
                EditorUtility.DisplayDialog("TMPHandler", $"No handlers were added. {componentsSkipped} TextMeshProUGUI components already had TMPHandler attached.", "OK");
            }
        }
        
        private static void ShowResultsDialog(int added, int skipped, List<string> modified)
        {
            if (modified.Count <= 5)
            {
                EditorUtility.DisplayDialog(
                    "TMPHandler Added",
                    $"Added TMPHandler to {added} TextMeshProUGUI components.\n\nModified objects: {string.Join(", ", modified)}\n\nSkipped {skipped} components that already had handlers.",
                    "OK"
                );
            }
            else
            {
                EditorUtility.DisplayDialog(
                    "TMPHandler Added",
                    $"Added TMPHandler to {added} TextMeshProUGUI components.\n\nModified objects: {string.Join(", ", modified.Take(5))}, and {modified.Count - 5} more...\n\nSkipped {skipped} components that already had handlers.",
                    "OK"
                );
            }
        }
        
        [MenuItem("Tools/BlacXGames/Add TMPHandler to Selected")]
        public static void AddTMPHandlerToSelected()
        {
            GameObject[] selectedObjects = Selection.gameObjects;
            
            // Keep track of stats for reporting
            int componentsAdded = 0;
            int componentsSkipped = 0;
            List<string> objectsModified = new List<string>();
            
            // Begin tracking changes for undo
            Undo.SetCurrentGroupName("Add TMPHandlers to Selection");
            int undoGroupIndex = Undo.GetCurrentGroup();
            
            foreach (GameObject obj in selectedObjects)
            {
                TextMeshProUGUI textComponent = obj.GetComponent<TextMeshProUGUI>();
                
                // Skip if the object doesn't have a TextMeshProUGUI component
                if (textComponent == null)
                    continue;
                
                // Skip if the component already has a TMPHandler
                if (textComponent.GetComponent<TMPHandler>() != null)
                {
                    componentsSkipped++;
                    continue;
                }
                
                // Register the object for undo
                Undo.RecordObject(obj, "Add TMPHandler");
                
                // Add the TMPHandler component
                TMPHandler handler = Undo.AddComponent<TMPHandler>(obj);
                
                // Mark the object as dirty so it gets saved
                EditorUtility.SetDirty(obj);
                
                componentsAdded++;
                objectsModified.Add(obj.name);
            }
            
            // End the undo group
            Undo.CollapseUndoOperations(undoGroupIndex);
            
            // Report results
            if (componentsAdded > 0)
            {
                Debug.Log($"Added TMPHandler to {componentsAdded} selected TextMeshProUGUI components. Skipped {componentsSkipped} components that already had handlers.");
                ShowResultsDialog(componentsAdded, componentsSkipped, objectsModified);
            }
            else
            {
                EditorUtility.DisplayDialog("TMPHandler", "No handlers were added. Make sure you have TextMeshProUGUI components selected.", "OK");
            }
        }
    }
}