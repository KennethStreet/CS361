import time
import requests


def user_input(number: int):
    if number == 1:
        prng = open("C:\\Users\\Kenne\\git\\Oregon_State\\CS361\\Assignment1\\Picture_Service\\prng-service.txt", "w")
        prng.write("run")
        prng.close()

        time.sleep(12)
        requests.get("http://localhost:8000/random-num-gen")
        time.sleep(5)

        prng = open("C:\\Users\\Kenne\\git\\Oregon_State\\CS361\\Assignment1\\Picture_Service\\prng-service.txt", "r")
        random_num = prng.readline()
        prng.close()

        open("C:\\Users\\Kenne\\git\\Oregon_State\\CS361\\Assignment1\\Image_Service\\image-service.txt", "w").close()
        image = open("C:\\Users\\Kenne\\git\\Oregon_State\\CS361\\Assignment1\\Image_Service\\image-service.txt", "w")
        image.write(random_num)
        image.close()

        time.sleep(12)
        requests.get("http://localhost:8080/image-service")
        time.sleep(5)

        f = open("C:\\Users\\Kenne\\git\\Oregon_State\\CS361\\Assignment1\\Image_Service\\image-service.txt", "r")
        line = f.readline()
        f.close()
        return line
    elif number == 2:
        return
    else:
        print("unknown option")


