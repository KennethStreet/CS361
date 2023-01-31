from fastapi import FastAPI
import random
app = FastAPI()


@app.get("/random-num-gen")
def random_num_generator() -> int:
    # Open and read file contents
    prng = open("prng-service.txt", "r")
    line = prng.readline()
    prng.close()

    if line == "run":
        # Generate random number
        num = random.random()

        # Erase file contents
        open("prng-service.txt", "w").close()

        # Write random number into file
        f = open("prng-service.txt", "w")
        f.write(str(num))
        f.close()

        return num

    return 0
