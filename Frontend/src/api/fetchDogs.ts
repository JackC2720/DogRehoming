export async function fetchDogs() {
  const headers = new Headers({
    'Content-Type': 'application/json',
    'x-api-key': `${import.meta.env.api_key}`,
  })

  const dogNames = [
    'Dufus',
    'Shirley',
    'John',
    'Tyrone',
    'Nana',
    'Ellie',
    'Fido',
    'Nugget',
    'Nigel',
    'Patty',
    'Shadow',
    'Craig',
    'Bouncer',
    'Mr Dog',
    'Rufus',
    'Starpig',
  ]

  const requestOptions: object = {
    method: 'GET',
    headers: headers,
    redirect: 'follow',
  }
  try {
    const response = await fetch(
      'https://api.thedogapi.com/v1/images/search?size=med&mime_types=jpg&format=json&has_breeds=true&order=RANDOM&page=0&limit=3',
      requestOptions,
    )

    const dogs = await response.json()

    const dogsWithName = dogs.map((dog: object, index: number) => ({
      ...dog,
      name: dogNames[index],
    }))

    return dogsWithName
  } catch (e) {
    console.error('error fetching data:', e)
    return []
  }
}
