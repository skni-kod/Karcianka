<template>
    <div class="patchNotesBox">
        <p class="panelTitle">PATCH NOTES</p>
        <ul class="notesList">
            <li class="noteElement" v-for="note in notes" :key="note.id">
                <p class="text">{{ note.message }}</p>
                <p class="button">Więcej</p>
                <p class="date">27-02-2022</p>
            </li>
        </ul>
    </div>
</template>
<script>
export default {
    data: () => {
        return {
            notes: [
                { id: '1', message: 'Poprawa systemu doboru graczy' },
                {
                    id: '2',
                    message: 'Dodanie nowej talii kart',
                },
                { id: '', message: 'Optymalizacja rozgrywki' },
                { id: '4', message: 'Dodanie nowych rozgrywek' },
            ],
        }
    },
}
</script>
<style lang="scss" scoped>
$pink-color: rgb(255, 0, 234);
$green-color: rgb(124, 255, 2);

.patchNotesBox {
    grid-column: 3/4;
    width: 100%;
    padding: 2rem 2rem 2rem 0;
    display: flex;
    justify-content: center;
    align-items: center;
    flex-direction: column;

    &::before {
        content: '';
        position: absolute;
        top: 0.4rem;
        left: 0.4rem;
        right: 2.4rem;
        bottom: 0.4rem;
        border: 0.15rem solid rgb(194, 28, 172);
        border-radius: 10px;
        box-shadow: 0px 0px 10px 0px $pink-color,
            inset 0px 0px 10px 0px $pink-color;
    }
    &::after {
        content: '';
        position: absolute;
        top: 0;
        left: 0;
        right: 2rem;
        bottom: 0rem;
        border: 0.15rem solid rgb(194, 28, 172);
        border-radius: 15px;
        box-shadow: 0px 0px 15px 0px $pink-color,
            inset 0px 0px 15px 0px $pink-color;
    }

    .panelTitle {
        font-family: NeonFontTitle;
        text-align: center;
        font-size: 3rem;
        margin: 0 0 0.5rem 0;
        letter-spacing: 0.1em;
        color: rgb(94, 255, 0);
        text-shadow: 0 0 5px $green-color, 0 0 10px $green-color,
            0 0 15px $green-color;
    }
    .notesList {
        list-style-type: none;
        width: 100%;
        height: 25rem;
        display: grid;
        grid-template-rows: repeat(5, 1fr);

        .noteElement {
            font-family: NeonFontButtons2;
            height: 5rem;
            width: 100%;
            display: grid;
            grid-template-columns: repeat(10, 1fr);
            grid-template-rows: repeat(4, 1fr);
            margin: 0.2rem 0 0 0;
            word-spacing: -0.4rem;

            .text {
                grid-column: 1/10;
                grid-row: 1/3;
                font-size: 1rem;
                padding: 0 0 0 1.5rem;
                letter-spacing: 0.05rem;
                white-space: normal;
                display: -webkit-box;
                -webkit-line-clamp: 2;
                -webkit-box-orient: vertical;
            }
            .button {
                grid-column: 2/4;
                grid-row: 4;
                font-size: 0.8rem;
                letter-spacing: 0.1rem;

                &:hover {
                    text-shadow: 0 0 3px white, 0 0 6px white;
                }
            }
            .date {
                grid-column: 7/11;
                grid-row: 4;
                font-size: 0.7rem;
                letter-spacing: 0.1rem;
                padding: 0 0 0 1rem;
            }
        }
    }
}
@media (min-width: 300px) and (max-width: 699px) {
    .patchNotesBox {
        grid-row: 3;
        width: 100%;
        font-size: 1rem;

        .panelTitle {
            font-size: 2.5rem;
        }
    }
}
@media (min-width: 700px) and (max-width: 1499px) {
    .patchNotesBox {
        grid-row: 2;
        grid-column: 2/3;
        width: 100%;
        font-size: 2.5rem;

        .panelTitle {
            font-size: 2.8rem;
        }
    }
}
</style>
