from fastapi import FastAPI
import time
import requests
app = FastAPI()


@app.get("/random_num_gen/{number}")
def user_input(number: int):
    if number == 1:
        prng = open("prng-service.txt", "w")
        prng.write("run")

        time.sleep(5)
        response = requests.get("/random-num-gen")

        open("image-service.txt", "w").close()
        image = open("image-service.txt", "w")
        image.write(response.content)
        time.sleep(5)

        f = open("image-service.txt", "r")
        line = f.readline()
        f.close()
        image.close()
        prng.close()
        return line
    elif number == 2:
        return
    else:
        print("unknown option")


