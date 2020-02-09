import numpy as np
import pygame
from time import time,sleep
from random import randint as r
import random
import pickle
n = 7
scrx = n*100
scry = n*100
background = (51,51,51)
screen = pygame.display.set_mode((scrx,scry))


colors = [(51,51,51) for i in range(n**2)]
reward = np.zeros((n,n))
terminals = []
penalities = 10

while penalities != 0:
    i = r(0,n-1)
    j = r(0,n-1)
    if reward[i,j] == 0 and [i,j] != [0,0] and [i,j] != [n-1,n-1]:
        reward[i,j] = -1
        penalities-=1
        colors[n*i+j] = (255,0,0)
        terminals.append(n*i+j)
        
reward[n-1,n-1] = 1
colors[n**2 - 1] = (0,255,0)
terminals.append(n**2 - 1)
####################################
Q = np.zeros((n**2,4))

actions = {"up": 0,"down" : 1,"left" : 2,"right" : 3}
states = {}
k = 0
for i in range(n):
    for j in range(n):
        states[(i,j)] = k
        k+=1
alpha = 0.01
gamma = 0.9
current_pos = [0,0]
epsilon = 0.25
def layout():
    c = 0
    for i in range(0,scrx,100):
        for j in range(0,scry,100):
            pygame.draw.rect(screen,(255,255,255),(j,i,j+100,i+100),0)
            pygame.draw.rect(screen,colors[c],(j+3,i+3,j+95,i+95),0)
            c+=1
###########
def select_action(current_state):
    global current_pos,epsilon
    possible_actions = []
    if np.random.uniform() <= epsilon:
        if current_pos[1] != 0:
            possible_actions.append("left")
        if current_pos[1] != n-1:
            possible_actions.append("right")
        if current_pos[0] != 0:
            possible_actions.append("up")
        if current_pos[0] != n-1:
            possible_actions.append("down")
        action = actions[possible_actions[r(0,len(possible_actions) - 1)]]##action = up down left ..
    else:
        m = np.min(Q[current_state])
        if current_pos[0] != 0:
            possible_actions.append(Q[current_state,0])
        else:
            possible_actions.append(m - 100)
        if current_pos[0] != n-1:
            possible_actions.append(Q[current_state,1])
        else:
            possible_actions.append(m - 100)
        if current_pos[1] != 0:
            possible_actions.append(Q[current_state,2])
        else:
            possible_actions.append(m - 100)
        if current_pos[1] != n-1:
            possible_actions.append(Q[current_state,3])
        else:
            possible_actions.append(m - 100)
        action = random.choice([i for i,a in enumerate(possible_actions) if a == max(possible_actions)])
        return action
    ######################
def episode():
    global current_pos,epsilon
    current_state = states[(current_pos[0],current_pos[1])]
    action = select_action(current_state)
    if action == 0:
        current_pos[0] -= 1
    elif action == 1:
        current_pos[0] += 1
    elif action == 2:
        current_pos[1] -= 1
    elif action == 3:
        current_pos[1] += 1#action 1->4  sus,jos,dreapta,stanga
    new_state = states[(current_pos[0],current_pos[1])]#locul nou al sferei
    if new_state not in terminals:# nu e perete sau final
        Q[current_state,action] += alpha*(reward[current_pos[0],current_pos[1]] + gamma*(np.max(Q[new_state])) 
                                          - Q[current_state,action])
    else:
        Q[current_state,action] += alpha*(reward[current_pos[0],current_pos[1]] - Q[current_state,action])
        current_pos = [0,0]
        epsilon -= 1e-3


run = True

current_pos = [0,0]
while run:
   # sleep(0.05)
    screen.fill(background)
    layout()
    pygame.draw.circle(screen,(25,130,230),(current_pos[1]*100 + 50,current_pos[0]*100 + 50),30,0)
    print(Q,end='\n')

    for event in pygame.event.get():
        if event.type == pygame.QUIT:
            run = False
    pygame.display.flip()
    episode()
pygame.quit()
