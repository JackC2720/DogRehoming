/** @type {import('tailwindcss').Config} */
export default {
  content: [
    'index.html',
    './src/*.ts',
    './src/*.vue',
    './src/components/*.vue',
    './src/views/*.vue',
  ],
  theme: {
    extend: {
      fontFamily: {
        inter: ['inter', 'sans-serif'],
      },
    },
  },
  plugins: [],
}
