from fastapi import FastAPI
import os
app = FastAPI()


@app.get("/image-service")
def image_service():
    image = open("image-service.txt", "r")
    line = image.readline()
    image.close()

    if line.isnumeric():
        num = int(line)
        image_num = number_of_images()

        if num >= image_num:
            num = num % image_num
            if num == 0:
                num = 1

        f = open("image-service.txt", "w")
        f.write(f'C:\\Users\\Kenne\\git\\Oregon_State\\CS361\\Assignment_1\\cs361\\{str(num)}.jpg')
        f.close()


def number_of_images() -> int:
    # folder path
    dir_path = r'C:\Users\Kenne\git\Oregon_State\CS361\Assignment_1\cs361'
    count = 0
    # Iterate directory
    for path in os.listdir(dir_path):
        # check if current path is a file
        if os.path.isfile(os.path.join(dir_path, path)):
            count += 1
    return count
