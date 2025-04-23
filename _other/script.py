import os, sys
os.chdir(os.path.dirname(__file__))
os.chdir('..\\M')
# print(os.getcwd())

dirs = sorted(os.listdir())

i = int(input('Jakou otázku z Matiky chcete expandovat? '))

file = [f for f in dirs if f.startswith(str(i))][0]
path = f'{file}\\{file}.md'

with open(path, encoding='utf-8') as f:
	text = [l.strip() for l in f.readlines()]

popis = text[3]
text = text[:3]
text.append('')
assert len(popis) > 10

fields = popis.split('-')[1]
for line in fields.split(','):
	splitted = f"""### {line.strip()}
"""
	text.append(splitted)

with open(path, 'w', encoding='utf-8') as f:
	text = '\n'.join(text)
	print(text)
	f.write(text)


# files = os.listdir()
# print('\n'.join(files))

# with open('M\\00 témata\\témata.txt', encoding='utf-8') as f:
# 	témata = [tuple(map(lambda x: x.strip(), t.strip().split('.'))) for t in f.readlines()]
# témata.sort(key=lambda t: int(t[0]))

# print(témata)
# with open('M\\00 témata\\popisy.txt', encoding='utf-8') as f:
# 	popisy = [t.strip() for t in f.readlines()]

# print(popisy)


# popisy_ordered = {}
# for p in popisy:
# 	for i, t in témata:
# 		val = p.split('-')[0].strip()[:10]
# 		if val in t:
# 			assert i not in popisy_ordered
# 			popisy_ordered[i] = p

# print()
# print(popisy_ordered)
# print(sorted(popisy_ordered.keys()), len(popisy_ordered))
# assert len(témata) == len(popisy_ordered)

# for tema in témata:
# 	i = tema[0]
# 	popis = popisy_ordered[i]
# 	name = ' '.join(tema)
# 	ss = f"""
# # {tema[0]} - {tema[1]}

# {popis}
# """
# 	filename = f'{name}.md'
# 	print(f'M\\{name}\\{filename}')
# 	with open(f'M\\{name}\\{filename}', 'w', encoding='utf-8') as f:
# 		pass
# 		# f.write(ss)
# 	# if os.path.exists('M\\' + str(i)):
# 	# 	# if os.path.exists('M\\' + str(name)):
# 	# 	# 	os.remove('M\\'+ name)
# 	# 	os.rename(f'M\\{i}', f'M\\{name}')
# 	# else:
# 	# 	os.mkdir(f'M\\{name}')

# # for f in os.listdir('M'):
# # 	if os.path.isfile(f): continue
# # 	i = int(f.split(' ')[0])
# # 	if i == 0: continue
# # 	if 'přímky' in f : continue
# # 	os.rename(f'M\\{f}', f'M\\{i}')
# 	# if i not in dirs:
# 	# 	dirs[i] = f
# 	# else:
# 	# 	if len(dirs[i]) < len(f):
# 	# 		dirs[i] = f

# # print(dirs)

# # for i, name in dirs.items():
# # 	file = f"{name}.jpeg"
# # 	try:
# # 		os.mkdir(f"M\\{name}")
# # 	except FileExistsError: pass
# # 	c = f'move "{file}" "M\\{name}\\{file}"'
# # 	print('cmd', c)
# # 	# os.system(c)

