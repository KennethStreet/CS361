# This is a sample Python script.

# Press Shift+F10 to execute it or replace it with your code.
# Press Double Shift to search everywhere for classes, files, tool windows, actions, and settings.
from fastapi import FastAPI
import Imgsrv
app = FastAPI()


@app.get("/")
async def root():
    # Use a breakpoint in the code line below to debug your script.
    return {"message": "Hello World"}


@app.get("/image-service")
async def random_number():
    Imgsrv.image_service()
    return {"message": "Image Path Copied to image-service.txt"}


# Press the green button in the gutter to run the script.
if __name__ == '__main__':
    root()

# See PyCharm help at https://www.jetbrains.com/help/pycharm/
