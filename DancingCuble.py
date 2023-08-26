# Blender script


import bpy
import math
import random


bpy.ops.mesh.primitive_cube_add(size=1, enter_editmode=False, align='WORLD', location=(0, 0, 0))
cube = bpy.context.object


mat = bpy.data.materials.new(name="UNI_Material")
mat.diffuse_color = (0.8, 0.2, 0.2, 1)
cube.data.materials.append(mat)

# Animation
frame_num = 0
for i in range(100):
    frame_num += 10
    
    # Tourne le cube
    cube.rotation_euler.z = math.radians(i * 20)
    
    # Change la scale du cube aléatoirement
    cube.scale.x = random.uniform(0.5, 13.5)
    cube.scale.y = random.uniform(0.5, 55.5)
    cube.scale.z = random.uniform(0.5, 35.5)
    
    # Change la couleur du cube aléatoirement
    mat.diffuse_color = (random.random(), random.random(), random.random(), 1)
    
    cube.keyframe_insert(data_path="rotation_euler", frame=frame_num)
    cube.keyframe_insert(data_path="scale", frame=frame_num)
    mat.keyframe_insert(data_path="diffuse_color", frame=frame_num)

# Params d'animation pour une boucle
bpy.context.scene.frame_start = 0
bpy.context.scene.frame_end = frame_num
bpy.context.scene.frame_set(0)

#modifis de courbe F pour rendre l'animation en boucle
cube.animation_data.action.fcurves[0].modifiers.new(type='CYCLES')
cube.animation_data.action.fcurves[1].modifiers.new(type='CYCLES')
cube.animation_data.action.fcurves[2].modifiers.new(type='CYCLES')
mat.animation_data.action.fcurves[0].modifiers.new(type='CYCLES')

# Lehomar2vinci
