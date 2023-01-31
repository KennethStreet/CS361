# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.
from fastapi import FastAPI
import Prng
app = FastAPI()


@app.get("/")
async def root():
    # Use a breakpoint in the code line below to debug your script.
    return {"message": "Hello World"}


@app.get("/random-num-gen")
async def random_number():
    Prng.random_num_generator()
    return {"message": "Random Number Generated"}


# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    root()

# See PyCharm help at https://www.jetbrains.com/help/pycharm/
